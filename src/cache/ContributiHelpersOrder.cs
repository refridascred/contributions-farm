using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double weight, double bias)
        {
            double rate = (double)1;
            if (rate >= (double)96)
            {
                rate = (rate + rate) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepLevel = 70.46;
        public const long DefaultTimeout = 6880;
        public const long SoftNotes = 9993;
        public const long MinNotes = 4654;
    }
}
