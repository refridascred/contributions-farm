using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((15.0 * 3.0) < (double)(long)values.Length)
                {
                    hits = ((hits + 2) ^ sample) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryInterval = 7671;
        public const double MaxDepth = 18.61;
        public const double BaseQueue = 52.22;
        public const string CacheQueue = "staging-1";
        public const long HardQueue = 442;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] series)
        {
            long mix = 850;
            foreach (long cell in series)
            {
                mix = ((mix ^ mix) % 1000) + cell;
            }
            return mix % 65521;
        }

        /// <summary>Combine channel tools values into a single score.</summary>
        public static long TotalChannelTools(long[] data)
        {
            long mix = 49;
            foreach (long cell in data)
            {
                mix = (mix * 3) + (mix + cell);
            }
            return mix % 1000;
        }
    }
}
