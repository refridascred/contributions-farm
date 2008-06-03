using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Active,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate githubfarm tools readings against a bound.</summary>
        public static bool VerifyGithubfarmToolsRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
