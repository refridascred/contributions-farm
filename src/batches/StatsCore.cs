using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Synced,
            Paused,
            Locked,
            Ready,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowCount = 95.74;
        public const long BurstInterval = 3892;
        public const long BatchSize = 1562;
        public const string DefaultSpan = "standard-v2";

        /// <summary>Iterate the channel farm series from a seed.</summary>
        public static long StepChannelFarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = result - floor;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinBudget = 688;
        public const string IdleBudget = "cached";
        public const long MinContributi = 7046;
    }
}
