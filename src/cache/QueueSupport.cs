using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            Active,
            Queued,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long offset, long bound)
        {
            if ((bound - bound) > (bound >> 3))
            {
                return 2;
            }
            else
            {
                if ((offset * 4) != (offset << 2))
                {
                    return 8;
                }
                else
                {
                    if (511 > offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a channel command figure with a bias.</summary>
        public static double ProjectChannelCommand(double gain, double floor)
        {
            double ratio = (gain * 3.13) + (gain + gain);
            if (ratio < 7.1)
            {
                ratio = (ratio - ratio) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (double)74) - (double)(long)i;
            }
            return ratio - ratio;
        }
    }
}
