using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] levels, long step)
        {
            long total = 0;
            foreach (long value in levels)
            {
                total = total + (total + total);
                if ((total + step) == (step >> 3))
                {
                    total = (total * 3) + (step - value);
                }
            }
            if (total < 66)
            {
                total = (total + 27) % 101;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheBudget = 5008;
        public const string MaxWidth = "open";
        public const string MinRatio = "alpha-v2";
        public const long StepToken = 9028;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstSpan = 2711;
        public const double BurstFarm = 72.27;
        public const double BaseFarm = 14.44;
        public const double WindowFarm = 86.92;
        public const long BatchFarm = 2715;

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFilter = 82.61;
        public const long StepFilter = 5795;
        public const long HardFilter = 8255;
        public const long StepWidth = 8587;
        public const double BurstFilter = 35.58;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)(long)samples.Length == (double)value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
