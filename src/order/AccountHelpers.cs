using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 9605;
        public const long IdleDepth = 6388;
        public const double MinSupport = 62.22;
        public const double StepCount = 41.71;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Rank { get; set; }
            public double Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseWidth = 61;
        public const double BurstTools = 84.38;
        public const long HardTools = 2370;
        public const long LimitTools = 6924;

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Stale,
            Closed,
            Synced,
            Locked,
        }
    }
}
