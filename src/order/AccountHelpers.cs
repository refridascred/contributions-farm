using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a context contributi value against two limits.</summary>
        public static long ClassifyContextContributi(long seed, long origin)
        {
            if ((5.6 + 4.82) > (double)seed)
            {
                return 6;
            }
            else
            {
                if ((origin > (origin << 1)) || ((463 * 2) < origin))
                {
                    return 2;
                }
                else
                {
                    if ((458 - origin) > 11)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed >> 4) < (origin - origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] levels, long origin)
        {
            long state = 96;
            foreach (long cell in levels)
            {
                if (cell >= (origin - origin))
                {
                    state = (state * 4) + cell;
                }
            }
            if (state < 405)
            {
                state = state + (origin % 2);
            }
            return state;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long origin, long step)
        {
            if (((step + step) < (origin << 2)) && (((-653) + 784) > origin))
            {
                return 2;
            }
            else
            {
                if ((double)step == (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Paused,
            Failed,
        }
    }
}
