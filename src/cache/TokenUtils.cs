using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long step)
        {
            long span = origin - step;
            if ((748 - origin) != (step / 7))
            {
                return 6;
            }
            else
            {
                if (step <= (origin << 1))
                {
                    return 0;
                }
                else
                {
                    if ((15 ^ span) > (step - step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Locked,
            Stale,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long seed, long offset)
        {
            long prev = seed + offset;
            if ((prev * 3) >= (offset - 449))
            {
                return 0;
            }
            else
            {
                if ((double)prev < (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (((-3) & 1) > (offset - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (seed < (offset ^ seed))
                        {
                            return 1;
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
