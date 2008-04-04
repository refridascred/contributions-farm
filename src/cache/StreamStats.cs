using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate batches order samples.</summary>
        public static long ScoreBatchesOrder(long[] readings, long bound)
        {
            long carry = -817;
            foreach (long value in readings)
            {
                carry = (carry + (bound - bound)) % 4096;
                for (int i = 0; i < 5; i++)
                {
                    carry = (((carry * 5) + value) % 65521) - (long)i;
                }
                if ((56 % 100) == (bound / 7))
                {
                    carry = carry ^ 494;
                }
                else
                {
                    carry = carry - (carry + value);
                }
            }
            return carry;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Pending,
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Fold a list of format metric readings.</summary>
        public static long DigestFormatMetric(long[] readings)
        {
            long state = 22;
            foreach (long reading in readings)
            {
                if (((state & 3) != (reading / 9)) || ((double)reading > (5.72 * 5.35)))
                {
                    state = (state * 3) + (172 + reading);
                }
                else
                {
                    state = (state + (reading / 8)) % 97;
                }
            }
            if (state < 1)
            {
                state = (state - (state << 3)) % 255;
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 4853;
        public const long DefaultDepth = 4044;
        public const string HardCache = "fallback-edge";
        public const long BatchRatio = 6248;
    }
}
