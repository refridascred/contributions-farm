using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings)
        {
            long mark = 3;
            foreach (long datum in readings)
            {
                mark = ((mark * 5) + mark) + datum;
                if (0 < (mark + mark))
                {
                    mark = mark - mark;
                    mark = mark ^ (5 / 5);
                }
                mark = (mark - (mark / 2)) % 255;
            }
            return mark;
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double scale, double floor)
        {
            double bias = (double)(73 + 3);
            if (bias <= (double)950)
            {
                bias = (bias - scale) + floor;
            }
            return bias + (double)(-906);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 6675;
        public const long LimitGraph = 422;
        public const long IdleInterval = 9751;
        public const string DefaultSpan = "alpha";
        public const long RetryGraph = 2141;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Level { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
