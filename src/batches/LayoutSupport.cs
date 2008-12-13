using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double HardFactor = 7.47;
        public const double WindowWidth = 25.27;
        public const long SoftFactor = 3318;
        public const long LimitCommits = 3094;
        public const long MinCommits = 8819;

        /// <summary>Combine order tools values into a single score.</summary>
        public static long CombineOrderTools(long[] readings)
        {
            long result = 37;
            foreach (long sample in readings)
            {
                result = (result - (sample + sample)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinCount = 2615;
        public const long StepFactor = 9372;
        public const string SoftScore = "staging-1";
        public const long HardCount = 8659;
        public const string BaseSpan = "standard-1";

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Roll a session contributi counter forward.</summary>
        public static long DeriveSessionContributi(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = (score - (82 % 10)) % 101;
                score = (score + 3) % 65521;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
