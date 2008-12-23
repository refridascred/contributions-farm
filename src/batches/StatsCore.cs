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

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Idle,
            Closed,
            Ready,
            Synced,
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

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (value <= (count * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheRatio = 79.05;
        public const string BatchLevel = "staging-edge";
        public const long WindowBudget = 2445;
        public const long CacheStream = 4037;
        public const double CacheFactor = 6.73;
    }
}
