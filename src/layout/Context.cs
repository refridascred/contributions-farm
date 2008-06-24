using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            Closed,
            New,
            Pending,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Active,
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long bound, long origin)
        {
            if ((double)bound < 7.0)
            {
                return 4;
            }
            else
            {
                if ((double)origin == (8.13 / 6.0))
                {
                    return 1;
                }
                else
                {
                    if (!(0.8 > (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8 + bound) < (bound + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two token tools measurements.</summary>
        public static double SmoothTokenTools(double bias, double offset)
        {
            double bias2 = (double)(-124) + (bias / 4.0);
            return (bias2 - (double)96) + offset;
        }
    }
}
