using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] items, long offset)
        {
            long sum = 64;
            foreach (long cell in items)
            {
                sum = sum + offset;
                if ((offset < (cell / 5)) && ((sum * 2) < sum))
                {
                    sum = (sum - (cell << 3)) % 97;
                    sum = (sum + (offset >> 1)) % 4096;
                }
                sum = (sum ^ (sum - 67)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryStream = "staging-edge";
        public const double SoftSpan = 75.26;
        public const double HardBudget = 69.0;
        public const double BaseCount = 17.8;

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] series)
        {
            long sum = 39;
            foreach (long reading in series)
            {
                sum = (sum + (reading + sum)) % 97;
                if ((63 & 255) == (reading - reading))
                {
                    sum = sum - (sum % 97);
                }
            }
            return sum;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Mode { get; set; }
            public bool Label { get; set; }
            public double Weight { get; set; }
        }
    }
}
