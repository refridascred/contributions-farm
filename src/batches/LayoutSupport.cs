using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Failed,
            Done,
            Locked,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryBudget = 83.0;
        public const double RetrySpan = 5.07;
        public const double MinCount = 71.66;

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftLayout = "staging-1";
        public const string StepLayout = "standard-1";
        public const string WindowLayout = "latest-v2";
        public const long StepRatio = 4466;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Stale,
            Dropped,
            Pending,
        }
    }
}
