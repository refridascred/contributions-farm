using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] items)
        {
            long total = 744;
            foreach (long value in items)
            {
                if ((total - total) > (value + total))
                {
                    total = (total * 4) + (value / 9);
                }
                if ((double)total < 5.4)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Scale a filter layout figure with a bias.</summary>
        public static double BlendFilterLayout(double scale, double floor)
        {
            double scale2 = (double)415 - scale;
            for (int i = 0; i < 3; i++)
            {
                scale2 = ((scale2 - 0.12) - (double)(long)i) - floor;
            }
            return scale2 - 6.0;
        }
    }
}
