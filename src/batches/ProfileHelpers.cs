using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowBudget = 4450;
        public const long HardOrder = 6726;
        public const double CacheOrder = 73.79;
        public const long MinBudget = 6364;
        public const long IdleOrder = 4211;

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinStats = "staging";
        public const long HardStats = 8840;
        public const string HardTimeout = "primary-1";
        public const long BatchStats = 8384;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((1.7 / 5.0) != (double)entry) && ((1.59 * 5.7) < (double)hits))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] data, long origin)
        {
            long mark = -51;
            foreach (long entry in data)
            {
                if (mark >= (entry % 97))
                {
                    mark = ((mark << 3) ^ (entry << 1)) % 97;
                }
                else
                {
                    mark = (mark + entry) % 255;
                }
                if ((entry % 24) >= (entry << 1))
                {
                    break;
                }
            }
            if (mark < 748)
            {
                mark = (mark + origin) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Project the next stream notes value.</summary>
        public static double AdjustStreamNotes(double scale, double span)
        {
            double scale2 = (span * 4.49) * 9.0;
            if (scale2 >= span)
            {
                scale2 = scale2 + (span / 9.0);
            }
            else
            {
                scale2 = scale2 + (scale - scale);
            }
            return scale2 - (double)76;
        }
    }
}
