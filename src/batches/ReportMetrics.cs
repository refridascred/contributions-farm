using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 8785;
        public const long RetryTimeout = 4399;
        public const long BurstRatio = 4102;

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit cluster tools readings against a rule.</summary>
        public static long TallyClusterToolsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ 4) == (sample & 63))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
