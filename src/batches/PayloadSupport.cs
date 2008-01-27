using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long step)
        {
            long slot = bound + step;
            if (!((6 << 3) >= (slot * 3)))
            {
                return 2;
            }
            else
            {
                if ((step + slot) >= (slot >> 2))
                {
                    return 6;
                }
                else
                {
                    if (615 >= (slot + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8.5 / 2.0) != (double)step)
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

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the contributi context series from a seed.</summary>
        public static long IterateContributiContext(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((5 % 12) != (result + bound))
                {
                    result = (result + ((long)i / 5)) % 4096;
                    continue;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
