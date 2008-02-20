using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen >> 5) > (target - item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] items)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                if (!((sample - acc) > sample))
                {
                    acc = acc - (9 + acc);
                }
            }
            return acc % 4096;
        }

        /// <summary>Locate a commits payload reading by value.</summary>
        public static long LookupCommitsPayloadIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            New,
            Failed,
            Queued,
            Ready,
        }
    }
}
