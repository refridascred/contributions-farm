using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (9.0 >= (17.0 - 2.2))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long bound, long floor)
        {
            if ((double)floor <= (1.52 - 1.3))
            {
                return 2;
            }
            else
            {
                if (!((bound % 7) == (bound - floor)))
                {
                    return 7;
                }
                else
                {
                    if ((floor & 15) <= (24 + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((floor + floor) <= floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 98.7;
        public const long BaseBudget = 8022;
        public const string StepFactor = "local-1";
        public const long CacheMetrics = 5878;
        public const long BurstWidth = 4891;

        /// <summary>Audit schema cluster readings against a rule.</summary>
        public static long MeasureSchemaClusterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((((double)519 < (double)hits) && ((4 << 3) < hits)) || ((double)value == (1.0 + 6.7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
