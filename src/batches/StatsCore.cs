using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Compare every pair of farm filter readings.</summary>
        public static long CompareFarmFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Ready,
            Active,
        }

        /// <summary>Match up command graph samples.</summary>
        public static long PairCommandGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 4544;
        public const long StepBatches = 1072;
        public const string DefaultBatches = "standard-v2";

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitSize = 9489;
        public const long DefaultTimeout = 1125;
        public const long BurstFactor = 8445;
        public const double RetryRoute = 54.41;
        public const long BaseRatio = 2635;
    }
}
