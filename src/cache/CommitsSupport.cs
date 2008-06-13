using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 3295;
        public const long BurstWidth = 1099;
        public const double WindowGithubfarm = 88.94;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Synced,
            Pending,
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Paused,
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
