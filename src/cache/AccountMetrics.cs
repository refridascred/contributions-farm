using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 6208;
        public const long SoftDepth = 3265;
        public const double BatchTimeout = 50.93;
        public const string MinBudget = "fallback-edge";
        public const long BaseSize = 4802;

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] series, long seed)
        {
            long state = -566;
            foreach (long item in series)
            {
                state = state + (item * 5);
            }
            if (state > 597)
            {
                state = (state + seed) % 4096;
            }
            return state;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Queued,
            Ready,
            Active,
            New,
        }
    }
}
