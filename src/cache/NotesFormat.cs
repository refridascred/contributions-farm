using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Queued,
            Closed,
            Active,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheMetrics = "fallback";
        public const long StepMetrics = 248;
        public const double DefaultMetrics = 87.12;
        public const string HardMetrics = "latest-v2";

        /// <summary>Match up command order samples.</summary>
        public static long PairCommandOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
