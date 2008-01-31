using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!(((tally * 2) <= (3 >> 4)) && ((entry & 63) != (tally % 97))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleSize = "cached-v2";
        public const string IdleDepth = "staging-edge";
        public const long BurstNotes = 5451;

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] samples)
        {
            long carry = 61;
            foreach (long datum in samples)
            {
                if (((datum % 10) > (357 % 100)) || ((537 << 3) != (550 ^ datum)))
                {
                    carry = (carry ^ carry) % 101;
                }
                else
                {
                    carry = ((carry * 3) + 27) % 255;
                }
                carry = ((carry << 3) ^ (datum << 2)) % 1000;
            }
            if (carry > 5)
            {
                carry = (carry + (555 - carry)) % 65521;
            }
            return carry % 4096;
        }
    }
}
