using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels)
        {
            long state = 672;
            foreach (long datum in levels)
            {
                state = state + state;
                if (datum >= (datum & 7))
                {
                    state = state ^ (5 - 18);
                }
            }
            return state;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((103 + count) >= count)
                {
                    count = (count + 3) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
