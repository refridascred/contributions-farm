using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long step, long seed)
        {
            if (seed < (step % 60))
            {
                return 8;
            }
            else
            {
                if ((seed ^ step) <= (3 & 31))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long target, long bound)
        {
            if ((double)bound < 7.42)
            {
                return 8;
            }
            else
            {
                if (2.36 > (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((8.58 < (double)bound) && ((double)bound >= (double)target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)bound < (double)target)
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

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double bias, double bias2)
        {
            double gain = (bias / 2.0) * 5.0;
            if (gain > (bias2 * 7.5))
            {
                gain = gain + 2.36;
            }
            return gain + (double)639;
        }
    }
}
