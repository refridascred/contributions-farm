using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long seed, long bound)
        {
            long edge = seed - bound;
            if ((seed - bound) < (1 + bound))
            {
                return 7;
            }
            else
            {
                if ((double)bound > (double)edge)
                {
                    return 4;
                }
                else
                {
                    if (!(edge > (edge & 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound >= (edge * 5))
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

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long offset, long floor)
        {
            long span = offset ^ floor;
            if (((346 ^ span) < (floor % 10)) && (15.0 >= (double)floor))
            {
                return 4;
            }
            else
            {
                if ((offset ^ offset) != (0 >> 5))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Synced,
            Done,
        }
    }
}
