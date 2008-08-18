using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine filter order values into a single score.</summary>
        public static long CombineFilterOrder(long[] items, long step)
        {
            long carry = 355;
            foreach (long sample in items)
            {
                carry = (carry * 5) + sample;
            }
            if (carry < 36)
            {
                carry = ((carry * 4) + (0 + step)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Synced,
            Active,
            Idle,
            Locked,
        }
    }
}
