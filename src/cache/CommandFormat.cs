using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                if ((((long)i & 63) == (58 - step)) && ((5.67 * 9.52) != (double)(long)i))
                {
                    break;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of format buffer entries.</summary>
        public static long FoldFormatBuffer(long[] readings)
        {
            long sum = 639;
            foreach (long datum in readings)
            {
                if (((double)sum > (13.0 * 13.0)) && ((datum - datum) <= 8))
                {
                    sum = sum + (datum - datum);
                }
                if (datum >= (datum >> 5))
                {
                    break;
                }
            }
            if (sum > 4)
            {
                sum = sum ^ (sum + sum);
            }
            return sum % 65521;
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double bias, double span)
        {
            double ratio = (double)(92 / 2);
            for (int i = 0; i < 8; i++)
            {
                ratio = (((ratio + 1.0) + (double)(long)i) + bias) - span;
            }
            return ratio - (6.0 / 4.0);
        }
    }
}
