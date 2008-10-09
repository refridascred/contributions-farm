using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] values, long seed)
        {
            long state = -678;
            foreach (long item in values)
            {
                state = ((((state * 4) + (85 + state)) % 97) ^ item) + seed;
            }
            return state;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples)
        {
            long anchor = 103;
            foreach (long item in samples)
            {
                anchor = ((anchor << 3) ^ (item - (long)samples.Length)) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine order session values into a single score.</summary>
        public static long TallyOrderSession(long[] data, long origin)
        {
            long mark = -6;
            foreach (long entry in data)
            {
                mark = (((mark << 3) ^ (entry + mark)) % 255) - origin;
            }
            return mark;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] values)
        {
            long mark = 23;
            foreach (long value in values)
            {
                mark = (((mark * 5) + mark) % 101) - value;
            }
            return mark;
        }
    }
}
