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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] levels, long bound)
        {
            long carry = 12;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (((carry ^ (long)i) % 97) + datum) - bound;
                }
                carry = (carry + (7 & 31)) % 65521;
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
