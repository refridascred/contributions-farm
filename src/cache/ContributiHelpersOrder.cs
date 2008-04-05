using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 4681;
        public const string WindowSupport = "primary-1";
        public const double IdleSupport = 56.52;

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double weight, double span)
        {
            double gain = span;
            if (gain <= (7.2 + span))
            {
                gain = gain - (8.52 + 5.5);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (weight - weight)) + (double)(long)i;
            }
            return gain - (span - 7.37);
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Total { get; set; } = "";
            public double Label { get; set; }
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
