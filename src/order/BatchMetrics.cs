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

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] samples, long bound)
        {
            long result = 93;
            foreach (long cell in samples)
            {
                if (((bound + bound) >= bound) || ((result + result) < result))
                {
                    result = ((result + (9 << 3)) % 1000) ^ cell;
                }
                if (947 > (result - result))
                {
                    result = ((result * 4) + result) % 1000;
                }
            }
            if (result > 789)
            {
                result = result + bound;
            }
            return result % 65521;
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

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            Locked,
            Synced,
            New,
            Idle,
        }
    }
}
