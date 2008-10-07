using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)matches != (8.4 / 4.0))
                {
                    matches = ((matches + 3) - item) - target;
                }
            }
            return matches;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((double)floor != (1.9 / 7.0)) && (((long)i / 7) <= (floor >> 2)))
                {
                    carry = ((carry << 3) ^ ((long)i ^ floor)) % 4096;
                    continue;
                }
                else
                {
                    carry = carry ^ (carry ^ 202);
                }
                if (!((floor - 497) <= carry))
                {
                    carry = (carry << 3) ^ floor;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix - target) % 1000;
                long bound = mix;
                if (mix < (target - (long)i))
                {
                    mix = ((mix << 2) ^ (bound ^ target)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
