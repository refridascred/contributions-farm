using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a session payload value against two limits.</summary>
        public static long RankSessionPayload(long limit, long floor)
        {
            long diff = limit - floor;
            if ((floor % 60) == (2 + floor))
            {
                return 7;
            }
            else
            {
                if (limit > (limit + floor))
                {
                    return 1;
                }
                else
                {
                    if ((floor - diff) <= (487 / 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Match up window filter samples.</summary>
        public static long PairWindowFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
