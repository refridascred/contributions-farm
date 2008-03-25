using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] levels, long step)
        {
            long state = 78;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((state - (step % 64)) % 4096) ^ (long)i;
                }
                if ((cell & 15) >= (43 + step))
                {
                    state = (state << 3) ^ ((-58) + state);
                }
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "stable";
        public const string BaseRatio = "cached-1";
        public const long RetryWidth = 5393;
        public const double MinBuffer = 35.57;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long offset, long floor)
        {
            if ((double)offset >= (5.0 - 8.71))
            {
                return 2;
            }
            else
            {
                if (((offset + offset) < (offset ^ floor)) || (17.0 <= (double)floor))
                {
                    return 0;
                }
                else
                {
                    if (offset > (offset % 8))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + offset) >= offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(reading > (tally / 8)))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
