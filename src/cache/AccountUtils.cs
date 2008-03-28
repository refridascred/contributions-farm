using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] items, long seed)
        {
            long result = 475;
            foreach (long sample in items)
            {
                if ((sample & 31) > (result - seed))
                {
                    result = (result << 2) ^ (sample / 7);
                    result = result - sample;
                }
                if ((result + result) != (7 >> 4))
                {
                    result = (result + seed) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 8170;
        public const long StepFactor = 6489;
        public const string StepQueue = "cached";
        public const long CacheQueue = 3712;

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Weight { get; set; }
            public long Level { get; set; }
            public bool Token { get; set; }
            public double Flag { get; set; }
        }
    }
}
