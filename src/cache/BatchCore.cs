using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "legacy-1";
        public const string BurstEditor = "cached-v2";
        public const string StepEditor = "local-v2";
        public const long IdleWidth = 7033;

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double weight, double offset)
        {
            double rate = weight;
            if (rate <= weight)
            {
                rate = rate - (double)311;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
