using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data)
        {
            long anchor = 1;
            foreach (long reading in data)
            {
                anchor = anchor - (6 & 7);
                anchor = ((anchor * 5) + (reading + reading)) % 97;
            }
            if (anchor > (-4))
            {
                anchor = anchor - anchor;
            }
            return anchor % 4096;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double bias, double bias2)
        {
            double ratio = (bias2 / 9.0) * 19.0;
            if (ratio > (bias - 12.0))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - (bias2 + bias);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (3.7 + bias)) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double weight, double span)
        {
            double rate = weight;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (double)(long)i) - span;
            }
            return rate - (rate + 9.0);
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] items, long target)
        {
            long mark = -192;
            foreach (long datum in items)
            {
                if (!(datum > (mark + 58)))
                {
                    mark = (((mark * 3) + mark) % 97) - target;
                }
                else
                {
                    mark = (mark ^ (567 >> 1)) % 65521;
                }
            }
            if (mark > 0)
            {
                mark = (mark - (mark & 1)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                sum = sum + (sum / 5);
                sum = ((sum << 2) ^ ((long)i >> 4)) % 4096;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
