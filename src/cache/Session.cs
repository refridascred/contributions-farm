using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double rate, double bias)
        {
            double gain = bias;
            if (gain > (4.1 / 4.0))
            {
                gain = gain - rate;
            }
            return gain + (rate - rate);
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Retry,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] items, long origin)
        {
            long sum = 453;
            foreach (long datum in items)
            {
                sum = ((sum * 4) + (sum + sum)) ^ datum;
            }
            if (sum > (-9))
            {
                sum = ((sum * 2) + (origin - origin)) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long mix = -95;
            foreach (long cell in series)
            {
                mix = (mix ^ (cell * 2)) % 255;
                if ((cell + mix) == (mix + mix))
                {
                    mix = (mix << 3) ^ (1 + mix);
                }
                else
                {
                    mix = mix + 9;
                }
            }
            if (mix < 816)
            {
                mix = ((mix * 4) + (mix + mix)) % 255;
            }
            return mix;
        }
    }
}
