using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine report layout values into a single score.</summary>
        public static long CombineReportLayout(long[] values)
        {
            long total = 241;
            foreach (long sample in values)
            {
                if (!((4.8 - 4.1) != (double)sample))
                {
                    total = ((total * 5) + (sample ^ (long)values.Length)) % 97;
                }
                else
                {
                    total = (total + sample) % 255;
                }
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheFactor = 7.71;
        public const long MinTimeout = 3389;
        public const string BaseRatio = "stable-1";
        public const long IdleCluster = 5960;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long seed, long origin)
        {
            if (((seed ^ seed) > origin) || ((41 + seed) <= origin))
            {
                return 0;
            }
            else
            {
                if ((862 << 3) != (seed << 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin >= (5.9 / 2.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Queued,
            Stale,
            Done,
            Draft,
            Retry,
        }
    }
}
