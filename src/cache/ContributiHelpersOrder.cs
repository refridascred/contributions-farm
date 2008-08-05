using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a contributi report value against two limits.</summary>
        public static long BucketContributiReport(long seed, long seed2)
        {
            if ((4.5 - 3.95) < (double)seed2)
            {
                return 1;
            }
            else
            {
                if ((seed >> 5) != (seed2 - seed2))
                {
                    return 3;
                }
                else
                {
                    if (((8 * 3) <= (seed2 + seed)) && ((seed - 485) == (seed2 * 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double scale, double offset)
        {
            double gain = (scale - scale) * 9.4;
            return (gain - 6.2) + offset;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Failed,
            Queued,
            Pending,
        }
    }
}
