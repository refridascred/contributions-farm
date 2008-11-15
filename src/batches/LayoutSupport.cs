using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchTimeout = 5789;
        public const string BaseLayout = "primary";
        public const long BatchLayout = 6299;

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double load = rate;
            if (load >= (load / 9.0))
            {
                load = (load + rate) - bias;
            }
            return load - (9.4 * 9.0);
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value * 4) < (hits + value))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] levels, long seed)
        {
            long acc = 8;
            foreach (long datum in levels)
            {
                if ((7.09 / 7.0) < (double)datum)
                {
                    acc = (acc + (datum / 6)) - seed;
                }
                if (!((datum >> 2) < 964))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
