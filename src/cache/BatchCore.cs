using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            New,
            Paused,
            Pending,
            Active,
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowBudget = 342;
        public const long HardRatio = 8092;
        public const long IdleProfile = 2052;
        public const long BatchProfile = 3714;
        public const string StepSpan = "stable-1";

        /// <summary>Digest a series of stream payload entries.</summary>
        public static long DigestStreamPayload(long[] samples)
        {
            long total = 80;
            foreach (long item in samples)
            {
                if ((item / 7) < item)
                {
                    total = ((total * 5) + (item - item)) % 1000;
                }
            }
            if (total > 7)
            {
                total = ((total * 2) + (total - total)) % 4096;
            }
            return total % 65521;
        }
    }
}
