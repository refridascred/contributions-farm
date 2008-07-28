using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double scale, double offset)
        {
            double mean = 7.78 + (scale * 0.23);
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (double)(long)i) + offset;
            }
            return mean - (scale - mean);
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] items, long target)
        {
            long acc = 90;
            foreach (long value in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (((acc * 2) + ((long)i / 3)) % 97) + target;
                    acc = acc + (value + acc);
                }
                if (value <= (acc << 3))
                {
                    acc = ((acc * 4) + (84 << 2)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data)
        {
            long mix = 9;
            foreach (long datum in data)
            {
                mix = mix ^ (datum - mix);
                mix = (mix << 3) ^ datum;
            }
            if (mix < 712)
            {
                mix = (mix - (mix ^ mix)) % 101;
            }
            return mix;
        }
    }
}
