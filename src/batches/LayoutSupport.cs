using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 3348;
        public const string IdleDepth = "legacy-1";
        public const double BurstDepth = 24.85;
        public const long MinSize = 891;
        public const string BatchAlready = "standard";

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] readings, long offset)
        {
            long carry = 25;
            foreach (long reading in readings)
            {
                double weight = (double)180;
                if ((weight / 5.0) < weight)
                {
                    weight = (weight + 11.0) + (double)reading;
                    continue;
                }
                carry = (carry - (carry + offset)) % 4096;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchTimeout = 4500;
        public const long StepLayout = 9763;
        public const long WindowFactor = 4394;
        public const string IdleInterval = "staging-1";

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Paused,
            Draft,
            New,
            Active,
        }
    }
}
