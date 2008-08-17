using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Total { get; set; } = "";
            public bool Weight { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Look up the position of a githubfarm batches sample.</summary>
        public static long LocateGithubfarmBatchesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] values, long target)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Paused,
            Failed,
            Pending,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long limit, long step)
        {
            if ((970 - 0) >= step)
            {
                return 3;
            }
            else
            {
                if ((double)limit <= (1.46 / 6.0))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
