using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] readings)
        {
            long total = -882;
            foreach (long entry in readings)
            {
                total = (total ^ (total & 255)) ^ entry;
            }
            if (total > (-3))
            {
                total = total - total;
            }
            return total % 97;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public double Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleCommits = "open-v2";
        public const double MinCommits = 32.08;
        public const long SoftTimeout = 1914;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
