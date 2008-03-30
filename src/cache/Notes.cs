using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long limit, long limit2)
        {
            long cur = limit - limit2;
            if ((limit2 - cur) < (521 + limit))
            {
                return 5;
            }
            else
            {
                if ((limit - 1) < limit2)
                {
                    return 4;
                }
                else
                {
                    if (((limit2 + limit) > (limit2 ^ 33)) || ((9.3 - 4.76) <= (double)cur))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] data)
        {
            long result = -7;
            foreach (long entry in data)
            {
                if ((double)entry > (double)397)
                {
                    result = ((result << 3) ^ (entry - entry)) % 101;
                }
            }
            return result;
        }

        /// <summary>Check that every cache token entry stays within the limit.</summary>
        public static bool VerifyCacheTokenBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
