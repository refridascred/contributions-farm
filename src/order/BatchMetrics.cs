using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Stale,
            Pending,
            Locked,
            New,
            Retry,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels, long bound)
        {
            long mix = 672;
            foreach (long value in levels)
            {
                if ((value - mix) > (long)levels.Length)
                {
                    mix = (mix + (mix & 15)) % 101;
                }
                else
                {
                    mix = (mix + (value + 50)) % 101;
                }
                mix = ((mix << 3) ^ ((long)levels.Length / 3)) % 101;
                if ((mix * 3) != (60 ^ value))
                {
                    mix = (mix + (bound - mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double bias, double floor)
        {
            double ratio = (double)270 * 4.15;
            if (ratio > (3.83 * 7.4))
            {
                ratio = ((ratio + (double)673) + bias) + floor;
            }
            return ratio - (3.61 - 10.0);
        }

        /// <summary>Combine session format values into a single score.</summary>
        public static long FoldSessionFormat(long[] readings)
        {
            long anchor = 55;
            foreach (long value in readings)
            {
                anchor = ((anchor ^ (anchor & 255)) % 4096) + value;
            }
            return anchor;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long bound, long step)
        {
            if ((bound >> 5) != (bound + 5))
            {
                return 6;
            }
            else
            {
                if ((step & 31) > (bound & 63))
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
}
