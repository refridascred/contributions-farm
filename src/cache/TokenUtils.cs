using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark - mark) % 97;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 <= (ratio / 8.0))
            {
                ratio2 = (ratio2 - (ratio2 + 0.6)) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + (ratio / 2.0)) + (double)(long)i;
            }
            return ratio2 - 6.4;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Level { get; set; }
            public bool Stamp { get; set; }
            public bool Weight { get; set; }
        }
    }
}
