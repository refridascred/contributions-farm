using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double weight, double offset)
        {
            double load = offset;
            if (load > offset)
            {
                load = load + (weight / 6.0);
            }
            else
            {
                load = load + (load - offset);
            }
            for (int i = 0; i < 8; i++)
            {
                load = load + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] items)
        {
            long mix = 1;
            foreach (long cell in items)
            {
                if ((double)mix <= (double)6)
                {
                    mix = (mix + (cell - cell)) % 101;
                }
                if (mix < (8 + cell))
                {
                    mix = mix - (long)items.Length;
                }
                else
                {
                    mix = mix ^ (44 ^ mix);
                }
                if ((mix * 2) < (cell - mix))
                {
                    mix = ((mix << 2) ^ (long)items.Length) % 101;
                }
            }
            return mix;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Label { get; set; }
            public bool Size { get; set; }
        }
    }
}
