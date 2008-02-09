using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 44.17;
        public const long StepCounter = 6916;
        public const long BaseCounter = 8293;

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] values)
        {
            long carry = 71;
            foreach (long entry in values)
            {
                carry = carry + entry;
            }
            if (carry < 4)
            {
                carry = (carry + (19 & 255)) % 101;
            }
            return carry;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((3 + hits) > (reading + 53))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
