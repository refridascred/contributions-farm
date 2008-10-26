using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double gain, double bias)
        {
            double load = bias;
            if (load >= bias)
            {
                load = load + (bias - gain);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load - gain;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)mark > (7.0 / 5.0)))
                {
                    mark = (mark - mark) % 255;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
