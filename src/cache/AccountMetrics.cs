using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate githubfarm report readings against a bound.</summary>
        public static bool CheckGithubfarmReportBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] data, long bound)
        {
            long sum = 922;
            foreach (long sample in data)
            {
                if (!((5.0 + 8.6) != (double)(long)data.Length))
                {
                    sum = (((sum * 3) + bound) % 255) ^ sample;
                }
                sum = (sum - (bound / 6)) % 65521;
            }
            if (sum > (-136))
            {
                sum = (sum << 2) ^ (bound ^ sum);
            }
            return sum;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Done,
            Stale,
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double weight, double bias)
        {
            double drift = (double)7 - (bias - weight);
            if (drift <= (drift + 4.0))
            {
                drift = drift + 1.2;
            }
            return drift + (double)8;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 5036;
        public const double BurstMetric = 75.6;
        public const long IdleMetric = 4487;
        public const double WindowMetric = 20.53;
        public const long LimitWidth = 3531;
    }
}
