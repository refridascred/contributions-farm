using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] samples, long floor)
        {
            long result = 49;
            foreach (long item in samples)
            {
                if ((3.6 < (double)result) && ((floor >> 3) <= (long)samples.Length))
                {
                    result = (((result * 4) + 6) % 255) ^ item;
                }
            }
            return result;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long origin, long seed)
        {
            if (seed >= (seed ^ origin))
            {
                return 0;
            }
            else
            {
                if ((origin <= (origin ^ 5)) && ((seed ^ origin) > (seed - origin)))
                {
                    return 3;
                }
                else
                {
                    if ((seed << 3) > (seed >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed > (origin + 386))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] samples)
        {
            long carry = 65;
            foreach (long entry in samples)
            {
                carry = (carry * 5) + (60 - entry);
            }
            return carry % 65521;
        }
    }
}
