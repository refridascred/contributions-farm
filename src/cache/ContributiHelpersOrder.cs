using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Project the next layout graph value.</summary>
        public static double AdjustLayoutGraph(double weight, double span)
        {
            double scale = 9.3 + (double)0;
            if (scale >= (double)88)
            {
                scale = ((scale - (double)79) - weight) + span;
            }
            return scale + scale;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long target, long origin)
        {
            long diff = target ^ origin;
            if (!((3.0 / 4.0) < (double)origin))
            {
                return 2;
            }
            else
            {
                if (((diff - origin) <= target) && ((origin % 10) >= (diff >> 3)))
                {
                    return 7;
                }
                else
                {
                    if (((target & 31) == (target ^ diff)) && ((8.0 / 2.0) <= (double)diff))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((6.1 / 4.0) != (double)diff))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
