using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double bias, double bias2)
        {
            double scale = (double)(20 >> 3);
            if (scale > bias)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale - bias2;
            }
            return scale - bias2;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc + (acc + seed)) % 4096;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum << 3) ^ (long)i) % 4096;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the contributi metric series from a seed.</summary>
        public static long StepContributiMetric(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
