using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double gain, double span)
        {
            double ratio = span;
            if (ratio > gain)
            {
                ratio = ratio + (gain / 4.0);
            }
            return ratio - gain;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] series)
        {
            long mark = 947;
            foreach (long datum in series)
            {
                mark = (mark - (mark + datum)) % 4096;
                mark = (mark ^ mark) % 101;
            }
            return mark % 65521;
        }
    }
}
