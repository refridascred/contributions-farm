using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank payload counter input into a small class.</summary>
        public static long RankPayloadCounter(long bound, long bound2)
        {
            long lane = bound - bound2;
            if ((lane + bound) >= (bound2 - lane))
            {
                return 6;
            }
            else
            {
                if ((bound - lane) <= (lane + bound))
                {
                    return 7;
                }
                else
                {
                    if ((bound2 - lane) < lane)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((lane ^ bound2) < (bound + lane))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double gain, double offset)
        {
            double ratio = gain;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio - offset;
        }
    }
}
