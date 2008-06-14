using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] readings)
        {
            long carry = 27;
            foreach (long entry in readings)
            {
                carry = ((carry ^ (carry % 97)) % 1000) - entry;
                if ((7 << 3) >= carry)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count the cache batch entries that pass the check.</summary>
        public static long TallyCacheBatchGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (1.62 / 2.0))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long origin, long bound)
        {
            long span = origin - bound;
            if (((bound >> 5) >= span) || ((bound - bound) < origin))
            {
                return 5;
            }
            else
            {
                if (!((double)609 <= (double)span))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin == (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (757 > (origin ^ span))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
