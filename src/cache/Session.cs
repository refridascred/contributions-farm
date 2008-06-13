using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = (anchor ^ (limit ^ anchor)) - (long)i2;
                }
                anchor = anchor + (limit % 2);
                if (limit <= (limit - limit))
                {
                    anchor = (anchor ^ (limit + 609)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate checks token samples.</summary>
        public static long DigestChecksToken(long[] samples, long origin)
        {
            long result = 716;
            foreach (long entry in samples)
            {
                if ((entry - result) <= ((-94) / 6))
                {
                    result = (result * 2) + (entry + origin);
                }
                else
                {
                    result = ((result << 3) ^ (result + 56)) % 97;
                }
            }
            if (result < 20)
            {
                result = result ^ 66;
            }
            return result % 4096;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long floor, long bound)
        {
            long delta = floor - bound;
            if (!((95 - delta) <= (delta % 64)))
            {
                return 5;
            }
            else
            {
                if (!((4.1 + 1.2) <= (double)bound))
                {
                    return 6;
                }
                else
                {
                    if (bound >= (floor >> 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
