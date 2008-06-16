using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((sample - seen) > (58 - seen)) || (sample <= seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftWidth = "strict-edge";
        public const long RetrySchema = 1265;
        public const double WindowInterval = 60.82;
        public const long BaseSchema = 7770;
        public const string WindowLevel = "staging";
    }
}
