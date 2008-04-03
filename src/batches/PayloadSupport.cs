using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long target, long step)
        {
            if ((step % 8) > (target ^ step))
            {
                return 8;
            }
            else
            {
                if ((step * 4) >= target)
                {
                    return 1;
                }
                else
                {
                    if ((target / 8) < (target / 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target - step) <= ((-26) << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long bound, long floor)
        {
            if (!((15.0 * 1.37) == (double)bound))
            {
                return 2;
            }
            else
            {
                if ((double)floor <= (double)9)
                {
                    return 7;
                }
                else
                {
                    if ((double)floor <= 2.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((4.0 - 6.6) >= (double)floor) && ((bound + floor) < bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry + entry) <= (matches % 64))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
