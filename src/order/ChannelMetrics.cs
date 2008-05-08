using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i >= (anchor + (long)i)) && ((8.1 / 3.0) <= (double)limit))
                {
                    anchor = anchor - (limit >> 4);
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = ((anchor * 3) + ((long)i >> 4)) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                total = (total * 5) + total;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 4605;
        public const long MaxCache = 2247;
        public const double BaseSpan = 97.78;
        public const long StepLevel = 6974;
        public const long RetryLevel = 3007;
    }
}
