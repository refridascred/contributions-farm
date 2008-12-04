using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long floor, long bound)
        {
            if (!((65 ^ 4) != (bound * 5)))
            {
                return 7;
            }
            else
            {
                if (floor <= (bound >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((68 + floor) == (floor >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the report graph series from a seed.</summary>
        public static long DeriveReportGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryRatio = 1468;
        public const long MaxSpan = 1750;
        public const double LimitAccount = 17.51;
        public const long HardDepth = 5640;

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxBudget = 1.4;
        public const long SoftEntry = 1381;
        public const long LimitInterval = 9512;
        public const string HardEntry = "fallback-edge";
        public const long IdleEntry = 5057;
    }
}
