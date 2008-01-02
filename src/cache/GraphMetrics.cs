using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 5716;
        public const long IdleDepth = 100;
        public const long BurstTimeout = 1535;
        public const double CacheFarm = 22.6;
        public const long StepSize = 4617;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Draft,
            Paused,
            Stale,
            Pending,
        }

        /// <summary>Roll a cache command counter forward.</summary>
        public static long DeriveCacheCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                score = (score + (target + target)) % 255;
                score = ((score << 3) ^ 74) % 97;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double mean = (double)(363 / 9);
            if (mean > (double)57)
            {
                mean = (mean + (15.0 + 1.4)) + scale;
            }
            return mean - floor;
        }
    }
}
