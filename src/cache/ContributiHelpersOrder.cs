using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate metrics editor samples.</summary>
        public static long FoldMetricsEditor(long[] readings)
        {
            long acc = 9;
            foreach (long entry in readings)
            {
                if (((acc + entry) >= entry) || ((entry * 3) < (entry + entry)))
                {
                    acc = (acc ^ acc) % 4096;
                }
            }
            if (acc < 48)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheLevel = 7.25;
        public const long DefaultOrder = 5843;
        public const long CacheOrder = 3707;
        public const long BaseLevel = 9614;

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] items)
        {
            long total = 23;
            foreach (long sample in items)
            {
                if ((total * 5) != (sample - total))
                {
                    total = (total << 3) ^ (total + total);
                }
                else
                {
                    total = ((total << 3) ^ total) % 101;
                }
            }
            if (total > 79)
            {
                total = (total << 3) ^ total;
            }
            return total % 65521;
        }
    }
}
