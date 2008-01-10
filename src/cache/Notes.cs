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

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples, long offset)
        {
            long total = 850;
            foreach (long item in samples)
            {
                if ((offset * 2) < total)
                {
                    total = ((total << 3) ^ (item - offset)) % 4096;
                }
                if ((double)offset > (9.46 + 2.2))
                {
                    total = (total * 5) + (total << 1);
                }
                else
                {
                    total = (total - offset) % 4096;
                }
                if (item > total)
                {
                    break;
                }
            }
            return total;
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
