using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] data, long step)
        {
            long mix = 360;
            foreach (long value in data)
            {
                if (!(value >= step))
                {
                    mix = (mix * 2) + (step % 7);
                }
                else
                {
                    mix = (mix << 2) ^ (mix / 2);
                }
                if (((double)mix <= (0.5 * 2.47)) || ((mix >> 3) < mix))
                {
                    break;
                }
            }
            if (mix < 64)
            {
                mix = (mix + (205 / 8)) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] items, long target)
        {
            long total = -316;
            foreach (long item in items)
            {
                total = ((total - (item >> 5)) % 1000) - target;
            }
            return total;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double ratio, double span)
        {
            double weight = span;
            if (weight > (ratio / 2.0))
            {
                weight = weight + (span + weight);
            }
            return weight - (weight / 9.0);
        }
    }
}
