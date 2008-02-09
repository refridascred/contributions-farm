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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((1 + tally) > ((-87) + tally))
                {
                    tally = ((tally + 3) ^ sample) + bound;
                }
            }
            return tally;
        }
    }
}
