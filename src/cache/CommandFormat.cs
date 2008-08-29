using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepFactor = 1239;
        public const long IdleBudget = 3163;
        public const long LimitLayout = 1924;
        public const string IdleLayout = "alpha-v2";
        public const long IdleSpan = 6986;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = (total << 2) ^ (2 << 3);
                total = ((total << 3) ^ origin) % 101;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry <= (step + 95))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
