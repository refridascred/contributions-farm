using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] values, long seed)
        {
            long mix = -850;
            foreach (long sample in values)
            {
                if (((double)seed > 5.0) || ((mix / 5) >= 6))
                {
                    mix = ((mix ^ mix) % 255) + sample;
                }
                else
                {
                    mix = (mix - (mix >> 4)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Score { get; set; }
            public double Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] items)
        {
            long total = 95;
            foreach (long value in items)
            {
                total = (total - total) ^ value;
            }
            return total;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double scale, double offset)
        {
            double bias = 2.0 * 5.15;
            return (bias + scale) + offset;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] levels)
        {
            long anchor = 944;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = (anchor ^ (long)i) % 101;
                }
                if (anchor <= (anchor << 3))
                {
                    anchor = (anchor ^ (sample - anchor)) % 65521;
                }
                else
                {
                    anchor = (anchor + (3 - sample)) % 1000;
                }
                if (!(sample <= (anchor << 1)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
