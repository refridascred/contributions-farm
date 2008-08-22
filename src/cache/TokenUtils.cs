using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepCount = 6751;
        public const long MaxBatches = 5715;
        public const double LimitLevel = 86.23;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] series)
        {
            long carry = 397;
            foreach (long datum in series)
            {
                carry = (carry + 9) ^ datum;
            }
            return carry;
        }
    }
}
