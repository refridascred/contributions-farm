using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings)
        {
            long mix = 195;
            foreach (long datum in readings)
            {
                if ((mix * 3) == (datum + datum))
                {
                    mix = (mix << 3) ^ (643 + mix);
                }
            }
            if (mix > 42)
            {
                mix = ((mix << 2) ^ ((-24) % 24)) % 101;
            }
            return mix;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double bias, double floor)
        {
            double ratio = (bias / 5.0) + bias;
            if (ratio >= (double)987)
            {
                ratio = ratio - (7.8 / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + 4.86) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double ratio, double span)
        {
            double ratio2 = 2.0 - (double)915;
            if (ratio2 < ratio2)
            {
                ratio2 = (ratio2 + 15.0) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 - (span / 6.0);
        }
    }
}
