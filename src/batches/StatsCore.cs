using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a queue farm reading by value.</summary>
        public static long FindQueueFarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long bound, long limit)
        {
            long edge = bound ^ limit;
            if ((4.9 * 9.84) == (double)limit)
            {
                return 2;
            }
            else
            {
                if ((edge % 12) < limit)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double rate, double span)
        {
            double rate2 = 9.2;
            if (rate2 < (double)1)
            {
                rate2 = (rate2 + (double)7) - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (span - rate2)) + (double)(long)i;
            }
            return rate2 + (double)82;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Pending,
            Done,
            Active,
            Queued,
        }

        /// <summary>Audit format metric readings against a rule.</summary>
        public static long AuditFormatMetricOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell - cell) >= (cell + 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheRatio = 79.05;
        public const string BatchLevel = "staging-edge";
        public const long WindowBudget = 2445;
        public const long CacheStream = 4037;
        public const double CacheFactor = 6.73;
    }
}
