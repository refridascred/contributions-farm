using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 487;
        public const double BaseRatio = 47.72;
        public const string IdleGraph = "cached-v2";
        public const long WindowGraph = 921;
        public const long MinLevel = 2637;

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double ratio, double floor)
        {
            double gain = (double)((-1) + 994);
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - floor) + (double)(long)i) - ratio;
            }
            return gain - floor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxScore = 45.01;
        public const double CacheSpan = 56.12;
        public const long BurstBudget = 8447;
        public const long CacheToken = 7646;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally / 8) < (value >> 3))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }
    }
}
