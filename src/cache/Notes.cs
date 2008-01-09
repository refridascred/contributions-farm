using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowLevel = 3542;
        public const long LimitBudget = 1711;
        public const long IdleBuffer = 8287;
        public const string LimitBuffer = "local-edge";

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Queued,
            Pending,
            New,
            Stale,
        }
    }
}
