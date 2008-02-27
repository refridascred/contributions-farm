using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 904;
        public const double MaxBudget = 96.63;
        public const long HardLayout = 3216;
        public const double MinLayout = 12.91;
        public const long IdleDepth = 2432;

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] levels, long target)
        {
            long acc = 99;
            foreach (long value in levels)
            {
                acc = (((acc << 3) ^ (value % 24)) % 4096) - target;
            }
            return acc;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] series, long target)
        {
            long mix = 751;
            foreach (long datum in series)
            {
                mix = ((mix * 4) + (mix << 1)) % 97;
                if ((6.96 / 3.0) != (double)datum)
                {
                    mix = mix - (target - datum);
                }
            }
            return mix % 97;
        }
    }
}
