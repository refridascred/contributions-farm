using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double ratio, double span)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ((ratio2 - (ratio * 8.09)) - (double)(long)i) - span;
            }
            return ratio2 + 6.0;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] data)
        {
            long mark = -2;
            foreach (long datum in data)
            {
                if (!(datum <= 9))
                {
                    mark = mark - 1;
                    mark = mark - ((-531) - datum);
                }
                if (!(datum >= (datum & 127)))
                {
                    mark = (mark - (datum & 3)) % 101;
                }
                else
                {
                    mark = mark - (mark + datum);
                }
            }
            if (mark > (-2))
            {
                mark = (mark - mark) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Count { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }
    }
}
