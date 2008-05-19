using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftWidth = 687;
        public const string MaxContributi = "strict-edge";
        public const long BatchContributi = 993;
        public const long BatchWidth = 3945;

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 2620;
        public const long RetryFarm = 7327;
        public const string StepBudget = "local-1";
        public const string HardCount = "stable";
        public const double SoftFactor = 66.02;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (tally < 60)
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }
    }
}
