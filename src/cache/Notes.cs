using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)sample > (6.0 / 3.0))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels, long target)
        {
            long sum = 292;
            foreach (long datum in levels)
            {
                sum = (sum ^ (target + sum)) - datum;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 6263;
        public const double CacheBudget = 34.88;
        public const long WindowCount = 2288;
        public const string BaseWidth = "standard-edge";

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitDepth = 6869;
        public const string WindowFactor = "alpha";
        public const long SoftCommand = 2821;
        public const long CacheCommand = 5084;
    }
}
