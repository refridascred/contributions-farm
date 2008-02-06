using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 753;
        public const double BaseMetrics = 54.13;
        public const long StepMetrics = 7325;
        public const string WindowWidth = "standard-v2";

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally % 60) <= (tally & 127))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] samples)
        {
            long carry = 6;
            foreach (long value in samples)
            {
                carry = (carry - (value ^ carry)) % 255;
            }
            return carry % 4096;
        }
    }
}
