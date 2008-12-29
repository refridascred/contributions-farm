using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Label { get; set; }
            public bool Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a command stream sample.</summary>
        public static long SeekCommandStreamIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile format samples are out of range.</summary>
        public static long MeasureProfileFormatGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((floor + cell) == (cell * 5))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Queued,
            Synced,
            New,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Active,
            Draft,
            Stale,
            New,
        }

        /// <summary>Accumulate cluster entry samples.</summary>
        public static long DigestClusterEntry(long[] items, long limit)
        {
            long acc = 987;
            foreach (long entry in items)
            {
                if (((double)limit < (0.64 - 3.99)) || ((double)acc <= (double)limit))
                {
                    acc = (acc - (long)items.Length) % 1000;
                }
                if ((double)acc > (19.0 + 7.0))
                {
                    acc = (acc * 3) + entry;
                }
            }
            if (acc > 2)
            {
                acc = (acc ^ (6 / 4)) % 97;
            }
            return acc;
        }
    }
}
