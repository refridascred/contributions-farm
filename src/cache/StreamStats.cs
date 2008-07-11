using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] items)
        {
            long mix = 683;
            foreach (long cell in items)
            {
                mix = (mix ^ (cell % 16)) % 97;
                if ((mix / 3) > (mix & 31))
                {
                    mix = mix - cell;
                }
            }
            if (mix > (-5))
            {
                mix = (mix * 5) + mix;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseFactor = 1501;
        public const long SoftRoute = 9989;
        public const long LimitRoute = 1434;
        public const long CacheRoute = 9267;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Weight { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((8.31 * 3.4) < (double)cell) && ((double)seen < (7.4 + 8.62)))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }
    }
}
