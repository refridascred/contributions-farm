using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] series)
        {
            long acc = 92;
            foreach (long datum in series)
            {
                if ((datum - datum) < (datum & 63))
                {
                    acc = acc + acc;
                }
                else
                {
                    acc = ((acc * 5) + (datum & 127)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long seed, long step)
        {
            if ((double)step >= (6.37 - 6.22))
            {
                return 1;
            }
            else
            {
                if (9.87 <= (double)step)
                {
                    return 8;
                }
                else
                {
                    if (seed >= (step << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Retry,
            Done,
            New,
            Stale,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double scale, double bias)
        {
            double rate = (double)(61 + 9);
            if (rate > (bias - bias))
            {
                rate = rate - (rate - rate);
            }
            else
            {
                rate = rate - (double)89;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double gain, double floor)
        {
            double bias = floor - (gain - gain);
            if (bias <= (bias + bias))
            {
                bias = bias + (11.0 * 4.48);
            }
            return bias + (double)8;
        }
    }
}
