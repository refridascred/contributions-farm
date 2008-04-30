using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double ratio, double bias)
        {
            double ratio2 = bias + (bias / 6.0);
            if (ratio2 >= (ratio * 13.0))
            {
                ratio2 = ratio2 - (double)2;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 - bias) + (double)(long)i;
            }
            return ratio2 - (ratio - ratio);
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double gain, double bias)
        {
            double ratio = bias;
            if (ratio >= gain)
            {
                ratio = ratio + gain;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + (bias * 20.0);
        }
    }
}
