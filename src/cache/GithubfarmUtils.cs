using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Pending,
            Retry,
            Dropped,
            Idle,
        }
    }
}
