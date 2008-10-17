using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Synced,
            Stale,
            Failed,
            Draft,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double gain, double floor)
        {
            double bias = 15.0;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias - (5.0 + floor)) + (double)(long)i) - gain;
            }
            return bias + (1.0 + floor);
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches - matches) == (matches + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((2 * 5) >= hits)
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((result * 4) < (result + floor))
                {
                    result = ((result * 3) + 682) % 255;
                }
                else
                {
                    result = result - ((long)i + floor);
                    result = (result << 3) ^ (floor - 221);
                }
                result = (result - (67 + 790)) % 1000;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitInterval = "legacy";
        public const long LimitRatio = 8052;
        public const long BurstSpan = 6550;
    }
}
