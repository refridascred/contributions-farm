using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public double Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long seed, long step)
        {
            if (((double)seed != (double)step) || ((double)seed >= (8.03 - 1.6)))
            {
                return 7;
            }
            else
            {
                if (seed < (seed % 10))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long origin, long target)
        {
            if (((double)target <= (double)(-886)) && ((target * 2) >= (origin % 12)))
            {
                return 5;
            }
            else
            {
                if (origin <= (target - 600))
                {
                    return 6;
                }
                else
                {
                    if (56 <= target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target * 2) <= 464)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
