using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 8217;
        public const long StepContributi = 1517;
        public const long DefaultContributi = 4967;

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryBudget = "alpha";
        public const long StepStream = 4965;
        public const long CacheFactor = 6121;

        /// <summary>Compare every pair of window format readings.</summary>
        public static long PairWindowFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Closed,
            Idle,
        }
    }
}
