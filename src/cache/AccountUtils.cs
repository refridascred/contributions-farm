using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Dropped,
            Idle,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long bound)
        {
            long total = bound;
            for (int i = 0; i < 22; i++)
            {
                total = (total ^ (bound - total)) % 1000;
                total = (total << 2) ^ (bound + total);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long step, long origin)
        {
            if ((1.57 / 3.0) != (double)step)
            {
                return 1;
            }
            else
            {
                if (!((step * 3) >= (origin / 7)))
                {
                    return 3;
                }
                else
                {
                    if (!((origin ^ step) >= step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((245 / 3) != (origin / 6))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
