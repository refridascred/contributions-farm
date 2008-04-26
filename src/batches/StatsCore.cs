using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Done,
            Failed,
            Queued,
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double rate, double floor)
        {
            double drift = rate;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (floor * 9.07)) + (double)(long)i;
            }
            return drift + (rate * 3.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 5292;
        public const long BaseMetric = 9781;
        public const string WindowMetric = "local-1";
        public const long DefaultMetric = 8774;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((tally % 64) > (tally << 3)) && ((double)tally > (14.0 + 8.81)))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long step, long limit)
        {
            if ((limit > (848 % 64)) || ((2 - limit) != (limit + limit)))
            {
                return 5;
            }
            else
            {
                if (2.0 < (double)step)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
