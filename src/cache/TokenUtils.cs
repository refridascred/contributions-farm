using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of token batches entries.</summary>
        public static long ScoreTokenBatches(long[] levels, long seed)
        {
            long mix = 26;
            foreach (long value in levels)
            {
                mix = (mix + (2 & 63)) % 255;
                if ((seed ^ mix) != (mix - mix))
                {
                    break;
                }
                mix = (mix + value) % 101;
            }
            if (mix > 1)
            {
                mix = (mix ^ mix) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Blend two queue report measurements.</summary>
        public static double BlendQueueReport(double scale, double bias)
        {
            double gain = (bias + 9.67) - scale;
            return gain + (double)194;
        }
    }
}
