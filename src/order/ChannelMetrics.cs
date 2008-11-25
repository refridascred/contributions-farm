using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of profile counter entries.</summary>
        public static long DigestProfileCounter(long[] values)
        {
            long acc = 5;
            foreach (long cell in values)
            {
                acc = (((acc << 3) ^ (acc - acc)) % 97) - cell;
            }
            return acc % 4096;
        }

        /// <summary>Classify a stats queue pair into a bucket.</summary>
        public static long GradeStatsQueue(long origin, long limit)
        {
            long step = origin ^ limit;
            if (step >= (step << 1))
            {
                return 6;
            }
            else
            {
                if ((step * 2) >= (step / 9))
                {
                    return 7;
                }
                else
                {
                    if ((origin ^ origin) > 27)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double rate, double offset)
        {
            double drift = (rate * 5.9) - (rate + 1.49);
            return (drift + (2.78 / 7.0)) + offset;
        }
    }
}
