using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 83.47;
        public const long BatchEntry = 8645;
        public const long LimitEntry = 4821;
        public const long MinEntry = 6750;
        public const string CacheEntry = "fallback-v2";

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] samples, long step)
        {
            long anchor = 342;
            foreach (long datum in samples)
            {
                if ((datum / 8) != (datum << 3))
                {
                    anchor = (anchor + (anchor * 4)) % 255;
                }
                if (datum > (datum & 15))
                {
                    anchor = (anchor ^ (anchor << 1)) % 4096;
                }
            }
            if (anchor > 76)
            {
                anchor = anchor ^ step;
            }
            return anchor;
        }

        /// <summary>Audit stream profile readings against a rule.</summary>
        public static long CountStreamProfileGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)limit == (6.0 * 6.0))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }
    }
}
