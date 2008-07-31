using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((7 + item) <= (floor >> 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepSpan = 4434;
        public const long BatchWidth = 5093;
        public const string LimitSize = "open";
        public const long SoftInterval = 4290;
        public const double WindowPayload = 84.06;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Offset { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
