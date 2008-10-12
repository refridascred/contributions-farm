using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((0 - datum) < (datum + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Queued,
            Active,
            Dropped,
            New,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] series, long bound)
        {
            long result = -7;
            foreach (long datum in series)
            {
                result = (((result * 5) + (datum * 3)) % 1000) - bound;
                result = (result ^ (result >> 5)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Active,
            Closed,
            New,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
