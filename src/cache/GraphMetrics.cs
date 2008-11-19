using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                if ((5 >> 3) <= (target + target))
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
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
