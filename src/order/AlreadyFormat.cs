using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double ratio, double span)
        {
            double weight = (double)(14 + 565);
            if (weight >= (double)333)
            {
                weight = (weight + span) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)546) + (double)(long)i;
            }
            return weight - 0.5;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((3.75 * 3.9) == (double)cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
