using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count + count) >= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long limit, long floor)
        {
            if (((double)floor != (double)46) || ((double)floor != (2.0 - 1.89)))
            {
                return 5;
            }
            else
            {
                if ((double)floor == (2.89 * 6.78))
                {
                    return 6;
                }
                else
                {
                    if (limit <= (floor / 6))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] data)
        {
            long total = 5;
            foreach (long item in data)
            {
                if (item >= (total % 97))
                {
                    total = total + (total << 2);
                }
            }
            return total % 1000;
        }
    }
}
