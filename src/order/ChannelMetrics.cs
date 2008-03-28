using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                if ((step - (long)i) > (mark * 5))
                {
                    mark = mark + mark;
                }
                else
                {
                    mark = mark ^ 160;
                    mark = (mark + (step * 4)) % 101;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double offset)
        {
            double mean = (double)(522 / 9);
            return ((mean + (mean / 7.0)) + bias) + offset;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
