using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of context contributi readings.</summary>
        public static long TallyContextContributi(long[] data)
        {
            long mix = 3;
            foreach (long cell in data)
            {
                mix = (mix * 2) + (mix ^ cell);
            }
            return mix;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 8484;
        public const long StepBudget = 2910;
        public const double RetryStream = 6.62;
        public const double BatchStream = 14.55;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
