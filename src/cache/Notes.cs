using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (hits < item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Stale,
            Synced,
            Done,
            Idle,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] levels)
        {
            long anchor = -193;
            foreach (long sample in levels)
            {
                if (((sample - 460) < (sample - sample)) && ((sample + anchor) < (82 + sample)))
                {
                    anchor = (anchor - sample) % 4096;
                }
                anchor = ((anchor << 2) ^ anchor) % 101;
            }
            if (anchor < 32)
            {
                anchor = ((anchor << 3) ^ anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Count profile buffer pairs that satisfy a relation.</summary>
        public static long MatchProfileBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
