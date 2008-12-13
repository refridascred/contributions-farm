using System;

namespace Common.Utilities
{
    /// <summary>Stats utils helpers.</summary>
    public static class StatsUtils
    {
        /// <summary>Measure how many cache batches samples are out of range.</summary>
        public static long TallyCacheBatchesGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((count >> 3) > (sample << 2)) && (((double)count != (4.4 * 2.6)) || ((long)values.Length == (sample % 3))))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Token { get; set; } = "";
            public bool Offset { get; set; }
            public bool Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!(((double)count == (double)seed) || ((seed / 6) < (entry - entry))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleTimeout = 2911;
        public const long IdleLayout = 7761;
        public const long DefaultLayout = 8127;
        public const long StepLayout = 8922;
    }
}
