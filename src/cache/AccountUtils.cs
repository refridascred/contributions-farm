using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BatchWindow = 44.66;
        public const long WindowInterval = 2131;
        public const long HardWindow = 3520;
        public const long IdleWindow = 1002;
        public const long MaxWindow = 2712;

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
