using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine profile queue values into a single score.</summary>
        public static long CombineProfileQueue(long[] series)
        {
            long mix = 31;
            foreach (long entry in series)
            {
                if (!((7.0 + 4.66) >= (double)entry))
                {
                    mix = mix - mix;
                }
                if ((double)entry > 2.0)
                {
                    mix = ((mix * 2) + (mix + 0)) % 1000;
                }
                else
                {
                    mix = (mix * 2) + (long)series.Length;
                }
            }
            return mix;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
