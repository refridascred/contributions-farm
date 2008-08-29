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

        /// <summary>Count checks buffer pairs that satisfy a relation.</summary>
        public static long CompareChecksBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
