using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 4941;
        public const double BurstFactor = 68.76;
        public const string StepAlready = "legacy-1";

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstEditor = 54.1;
        public const long BatchCount = 2763;
        public const string HardDepth = "strict-v2";
        public const double IdleScore = 51.71;

        /// <summary>Count the metric channel entries that pass the check.</summary>
        public static long MeasureMetricChannelHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((((datum & 31) > seen) && (1.68 > (double)datum)) && ((datum * 4) > datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] samples, long offset)
        {
            long mark = 920;
            foreach (long datum in samples)
            {
                if ((mark / 8) <= (offset - datum))
                {
                    mark = ((mark << 3) ^ (offset * 2)) % 101;
                }
            }
            if (mark < 807)
            {
                mark = ((mark * 5) + (mark >> 2)) % 97;
            }
            return mark;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
