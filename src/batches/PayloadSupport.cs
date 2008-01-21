using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a filter graph value against two limits.</summary>
        public static long GradeFilterGraph(long bound, long limit)
        {
            if ((2.5 * 9.59) < (double)bound)
            {
                return 0;
            }
            else
            {
                if ((limit + bound) != (limit >> 1))
                {
                    return 5;
                }
                else
                {
                    if ((limit <= 55) || ((double)bound < (15.0 * 8.7)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound < (bound + bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a window cache value against two limits.</summary>
        public static long GradeWindowCache(long origin, long offset)
        {
            long cur = origin - offset;
            if ((double)origin > (double)offset)
            {
                return 4;
            }
            else
            {
                if ((offset ^ origin) < (origin * 4))
                {
                    return 0;
                }
                else
                {
                    if (origin <= (offset - cur))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a graph schema reading by value.</summary>
        public static long SeekGraphSchemaIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
