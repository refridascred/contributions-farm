using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long seed, long bound)
        {
            if (!((68 - seed) <= (bound & 63)))
            {
                return 2;
            }
            else
            {
                if (((bound % 97) > seed) || ((seed + seed) <= (seed * 5)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long bound, long offset)
        {
            long diff = bound - offset;
            if (!((double)bound <= 9.13))
            {
                return 4;
            }
            else
            {
                if (((bound ^ 46) != (offset >> 4)) || ((diff % 24) != (diff / 7)))
                {
                    return 2;
                }
                else
                {
                    if (offset > (offset >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first route record entry that matches the target.</summary>
        public static long SeekRouteRecordIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Locked,
            Synced,
            Closed,
        }
    }
}
