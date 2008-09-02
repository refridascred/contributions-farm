using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double bias, double span)
        {
            double ratio = span;
            if (ratio <= (bias - 3.0))
            {
                ratio = ratio + (double)96;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (span * 7.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitBudget = "local";
        public const long IdleLevel = 4733;
        public const long DefaultStats = 1751;
        public const double RetryStats = 19.94;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((item / 3) <= (item + 14)))
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            New,
            Synced,
            Failed,
            Retry,
            Stale,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Draft,
            Queued,
            New,
            Paused,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] samples, long target)
        {
            long result = 6;
            foreach (long sample in samples)
            {
                result = (((result * 2) + (-854)) ^ sample) - target;
            }
            if (result < 1)
            {
                result = (result ^ 941) % 1000;
            }
            return result;
        }
    }
}
