using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((8 - limit) == ((-51) - 1)))
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleInterval = 6608;
        public const long LimitRatio = 442;
        public const string BatchStats = "alpha";

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Paused,
            Done,
            Draft,
            Idle,
            Pending,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double bias, double floor)
        {
            double mean = (double)254 + bias;
            if (mean < (double)3)
            {
                mean = (mean - bias) - floor;
            }
            else
            {
                mean = mean + bias;
            }
            return mean + (5.0 + mean);
        }
    }
}
