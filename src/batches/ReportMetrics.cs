using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] samples)
        {
            long anchor = 29;
            foreach (long sample in samples)
            {
                if ((anchor >> 4) >= sample)
                {
                    anchor = (anchor + (anchor + sample)) % 97;
                }
            }
            if (anchor < 0)
            {
                anchor = anchor ^ (anchor + 989);
            }
            return anchor;
        }

        /// <summary>Look up the position of a notes metric sample.</summary>
        public static long SeekNotesMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "open-1";
        public const long BatchFactor = 1097;
        public const double BatchSize = 88.8;
    }
}
