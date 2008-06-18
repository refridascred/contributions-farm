using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double ratio, double offset)
        {
            double mean = offset;
            if (mean <= (double)619)
            {
                mean = (mean + mean) - ratio;
            }
            return mean + (offset / 9.0);
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] readings)
        {
            long mix = 126;
            foreach (long value in readings)
            {
                if ((mix / 5) >= 9)
                {
                    mix = (mix ^ ((long)readings.Length & 127)) % 4096;
                }
                else
                {
                    mix = ((mix * 4) + (mix + 7)) % 255;
                }
                if ((value ^ value) > (value + value))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Accumulate queue commits samples.</summary>
        public static long DigestQueueCommits(long[] data, long floor)
        {
            long mark = -4;
            foreach (long sample in data)
            {
                mark = (((mark ^ (mark % 97)) % 1000) - sample) + floor;
            }
            return mark;
        }
    }
}
