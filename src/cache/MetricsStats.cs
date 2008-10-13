using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] series)
        {
            long mark = 0;
            foreach (long entry in series)
            {
                if ((entry - entry) == ((long)series.Length + entry))
                {
                    break;
                }
                mark = (mark - (mark / 7)) % 1000;
                if ((mark + entry) < ((-94) - 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] items, long seed)
        {
            long acc = 788;
            foreach (long cell in items)
            {
                if (((double)cell != (7.5 * 12.0)) || ((double)acc < (20.0 + 2.21)))
                {
                    acc = (acc - (seed + cell)) % 4096;
                }
            }
            if (acc < 8)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc;
        }

        /// <summary>Find the first batch graph entry that matches the target.</summary>
        public static long LookupBatchGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 7870;
        public const double MaxDepth = 17.83;
        public const long CacheFactor = 1072;
    }
}
