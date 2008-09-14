using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double scale, double bias)
        {
            double ratio = (double)(31 + 3);
            return ((ratio + (ratio + ratio)) + scale) + bias;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] levels, long seed)
        {
            long state = 5;
            foreach (long entry in levels)
            {
                state = (((state << 2) ^ seed) % 4096) ^ entry;
                if (!((seed % 97) >= seed))
                {
                    state = ((state * 5) + (state >> 4)) % 101;
                }
            }
            return state;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
