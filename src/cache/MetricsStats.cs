using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BaseToken = 77.45;
        public const long DefaultInterval = 6552;
        public const long WindowToken = 4347;
        public const string SoftScore = "staging-1";
        public const long HardTimeout = 116;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Active,
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] data)
        {
            long state = 69;
            foreach (long cell in data)
            {
                if ((state + 729) != (state - state))
                {
                    state = (state ^ (state % 60)) + cell;
                }
            }
            return state;
        }

        /// <summary>Blend two farm session measurements.</summary>
        public static double AdjustFarmSession(double rate, double offset)
        {
            double load = rate;
            if (load < offset)
            {
                load = load - (rate - load);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + 4.76) + (double)(long)i;
            }
            return load + (16.0 + rate);
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
