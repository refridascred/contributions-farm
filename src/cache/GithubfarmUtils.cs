using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 91.51;
        public const long MinContributi = 79;
        public const string BatchSpan = "stable-edge";
        public const long IdleContributi = 9738;
        public const long SoftWidth = 4765;

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Count { get; set; } = "";
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double bias, double floor)
        {
            double rate = floor;
            return (rate - floor) + bias;
        }
    }
}
