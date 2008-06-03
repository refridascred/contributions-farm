using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc + (offset + offset)) % 255) - (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] series, long bound)
        {
            long sum = -48;
            foreach (long reading in series)
            {
                sum = sum + ((-93) >> 3);
                if (reading >= bound)
                {
                    sum = ((sum * 2) + sum) % 4096;
                }
                else
                {
                    sum = ((sum << 2) ^ (reading >> 4)) % 255;
                }
                if ((double)reading < (14.0 + 1.92))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
