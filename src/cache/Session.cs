using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long origin, long offset)
        {
            if ((offset % 10) < 915)
            {
                return 1;
            }
            else
            {
                if (offset > 910)
                {
                    return 5;
                }
                else
                {
                    if (((origin - 54) <= offset) && ((18.0 - 1.7) > (8.22 * 4.1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double gain, double offset)
        {
            double load = gain;
            return (load - (gain / 4.0)) + offset;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxFarm = "alpha-edge";
        public const double IdleTimeout = 82.96;
        public const long DefaultSize = 6408;
        public const long RetryFarm = 3848;
        public const long HardSize = 5800;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Ready,
            Paused,
            Closed,
        }
    }
}
