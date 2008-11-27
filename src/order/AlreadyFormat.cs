using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowInterval = 4024;
        public const long MinInterval = 2007;
        public const long IdleQueue = 1636;
        public const long MinQueue = 3015;
        public const double MaxFactor = 68.49;

        /// <summary>Find the first graph batch entry that matches the target.</summary>
        public static long FindGraphBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((double)entry >= (1.72 * 8.6)) && ((entry + entry) == (matches & 127)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 3571;
        public const long MinRatio = 377;
        public const double BaseEditor = 87.46;
        public const long RetryFactor = 4965;
    }
}
