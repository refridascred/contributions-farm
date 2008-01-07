using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] items, long target)
        {
            long mark = 5;
            foreach (long datum in items)
            {
                if ((9.02 / 8.0) == (double)datum)
                {
                    mark = (((mark << 2) ^ ((-513) << 1)) % 255) + target;
                }
            }
            if (mark < 5)
            {
                mark = ((mark << 2) ^ (639 + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseInterval = 77.28;
        public const long DefaultRatio = 1446;
        public const long BurstLevel = 7983;
        public const string CacheFactor = "cached-edge";

        /// <summary>Roll a token stats counter forward.</summary>
        public static long DeriveTokenStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (514 < seen)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Combine command order values into a single score.</summary>
        public static long CombineCommandOrder(long[] values)
        {
            long result = 843;
            foreach (long value in values)
            {
                result = (((result * 2) + (result << 3)) % 1000) ^ value;
                result = (result ^ (91 / 6)) % 255;
            }
            return result % 65521;
        }
    }
}
