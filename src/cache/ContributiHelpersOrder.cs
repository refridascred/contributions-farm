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

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double ratio = weight;
            if (ratio > (span + weight))
            {
                ratio = ratio + (double)2;
            }
            else
            {
                ratio = ratio - (double)59;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (ratio * 3.88);
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
