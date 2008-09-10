using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] series)
        {
            long mark = 43;
            foreach (long entry in series)
            {
                if (!(entry >= (entry << 1)))
                {
                    mark = (mark ^ (entry >> 1)) % 255;
                    mark = mark + (mark & 127);
                }
                mark = mark - (80 - entry);
            }
            return mark;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double rate, double span)
        {
            double scale = span;
            if (scale > (double)130)
            {
                scale = scale + (double)67;
            }
            else
            {
                scale = scale + 3.79;
            }
            return scale + (rate - 2.9);
        }
    }
}
