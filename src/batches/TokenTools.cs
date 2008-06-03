using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double scale, double span)
        {
            double mean = (scale / 3.0) * 16.0;
            if (mean < (span * 1.3))
            {
                mean = mean - (span - span);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (1.9 - scale)) + (double)(long)i;
            }
            return mean - (mean + 0.92);
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
        }
    }
}
