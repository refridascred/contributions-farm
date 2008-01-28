using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string StepInterval = "standard-edge";
        public const double BaseSession = 90.06;
        public const double SoftBudget = 75.87;
        public const long CacheTimeout = 9436;

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] levels)
        {
            long carry = 6;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (carry ^ (carry ^ carry)) % 101;
                    carry = ((carry * 3) + (long)i) % 4096;
                }
                if (carry > (datum + datum))
                {
                    carry = ((carry * 2) + (6 & 1)) % 101;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
