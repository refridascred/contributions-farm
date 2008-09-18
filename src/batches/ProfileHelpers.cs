using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine report schema values into a single score.</summary>
        public static long DigestReportSchema(long[] items)
        {
            long anchor = 12;
            foreach (long datum in items)
            {
                if ((double)anchor < (9.75 + 3.0))
                {
                    anchor = (anchor * 3) + (anchor - anchor);
                }
                else
                {
                    anchor = (anchor * 2) + (datum << 2);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] data)
        {
            long mix = -86;
            foreach (long sample in data)
            {
                if ((mix % 64) >= mix)
                {
                    mix = ((mix << 3) ^ sample) % 97;
                }
            }
            return mix;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Size { get; set; }
            public double Token { get; set; }
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "staging-edge";
        public const string StepCluster = "stable";
        public const long MaxInterval = 417;

        /// <summary>Audit cache counter readings against a rule.</summary>
        public static long CountCacheCounterHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (step >= seen)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
