using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                if (mix > (mix + 9))
                {
                    mix = mix - offset;
                    mix = (mix * 5) + mix;
                }
                if (((offset + mix) <= (offset + offset)) && ((double)offset < 3.0))
                {
                    mix = mix - (offset - 2);
                }
                else
                {
                    mix = mix ^ (offset % 16);
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long origin, long origin2)
        {
            long bound = origin + origin2;
            if ((863 / 2) >= origin)
            {
                return 1;
            }
            else
            {
                if ((double)origin > 9.0)
                {
                    return 6;
                }
                else
                {
                    if (!(origin >= (origin2 - origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (4 >= (bound / 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchRatio = 76.36;
        public const long MinSpan = 8531;
        public const double StepStream = 3.84;
        public const long MaxStream = 6636;
    }
}
