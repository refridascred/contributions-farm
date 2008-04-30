using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double weight, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (double)9) + (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long offset, long seed)
        {
            if ((7.58 / 5.0) > (double)offset)
            {
                return 2;
            }
            else
            {
                if (!((double)seed >= (15.0 + 2.1)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Queued,
            Stale,
            Paused,
            Locked,
        }
    }
}
