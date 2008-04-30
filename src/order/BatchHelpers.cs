using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of counter filter entries.</summary>
        public static long ScoreCounterFilter(long[] levels, long floor)
        {
            long acc = 195;
            foreach (long reading in levels)
            {
                if ((floor >> 1) <= (acc / 2))
                {
                    acc = (acc + (floor + reading)) % 1000;
                }
                else
                {
                    acc = acc ^ floor;
                }
            }
            if (acc < 2)
            {
                acc = (acc ^ (acc >> 4)) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long anchor = 517;
            foreach (long item in samples)
            {
                anchor = (anchor << 2) ^ item;
                anchor = (anchor << 3) ^ anchor;
            }
            if (anchor < 34)
            {
                anchor = (anchor ^ (anchor + 279)) % 101;
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 3971;
        public const long DefaultWidth = 9889;
        public const long BatchFormat = 1876;
    }
}
