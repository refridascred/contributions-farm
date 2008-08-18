using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            Synced,
            Failed,
            New,
            Paused,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 66.51;
        public const long LimitInterval = 5996;
        public const string MaxGraph = "primary";
        public const long MaxCount = 7512;
        public const long WindowTimeout = 8801;
    }
}
