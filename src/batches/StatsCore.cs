using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double bias, double floor)
        {
            double load = 4.3;
            if (load <= (bias + floor))
            {
                load = load + floor;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load + (double)6;
        }

        /// <summary>Audit context format readings against a rule.</summary>
        public static long CountContextFormatHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((72 / 7) >= (cell >> 4))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryFactor = 5584;
        public const long LimitTools = 8271;
        public const string BaseTimeout = "standard-1";

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 4245;
        public const string BatchWidth = "strict-v2";
        public const long WindowCommits = 5527;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Pending,
            Stale,
            Queued,
        }
    }
}
