using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 56.71;
        public const string StepLayout = "local-v2";
        public const double BatchLayout = 41.31;
        public const long SoftFactor = 7362;
        public const long DefaultFactor = 8810;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Score { get; set; }
            public double Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double ratio, double offset)
        {
            double load = ratio - (double)69;
            if (load <= (double)4)
            {
                load = load + (offset * 4.91);
            }
            else
            {
                load = load + (offset * 1.76);
            }
            return load + (load + ratio);
        }
    }
}
