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

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double ratio, double span)
        {
            double rate = (ratio - ratio) / 7.0;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + span;
        }
    }
}
