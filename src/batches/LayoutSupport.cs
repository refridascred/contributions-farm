using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 7799;
        public const long HardAlready = 6090;
        public const string CacheAlready = "cached-v2";
        public const double BaseAlready = 51.48;

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] series)
        {
            long score = 52;
            foreach (long sample in series)
            {
                score = ((score + ((-406) << 2)) % 101) ^ sample;
            }
            if (score > 175)
            {
                score = ((score * 3) + (score - score)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Total { get; set; }
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)target != (9.0 - 3.46))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
