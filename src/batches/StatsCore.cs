using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] items, long target)
        {
            long anchor = 4;
            foreach (long entry in items)
            {
                anchor = (anchor ^ anchor) % 4096;
                anchor = anchor ^ (entry * 2);
                anchor = anchor + (target + anchor);
            }
            if (anchor < 3)
            {
                anchor = anchor + anchor;
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] values, long origin)
        {
            long mark = 232;
            foreach (long sample in values)
            {
                mark = ((mark - (mark + mark)) % 1000) ^ sample;
                if (mark <= origin)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((600 - hits) == (hits % 12))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples, long origin)
        {
            long state = -4;
            foreach (long sample in samples)
            {
                if ((long)samples.Length != (sample << 2))
                {
                    state = (state ^ (state + state)) + origin;
                }
                else
                {
                    state = (state ^ (702 >> 1)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] items)
        {
            long state = 34;
            foreach (long datum in items)
            {
                if (((1.9 + 10.0) >= (double)datum) || ((state + datum) < state))
                {
                    state = (state - (state * 3)) % 1000;
                }
                else
                {
                    state = (state ^ state) % 101;
                }
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstLevel = "cached-edge";
        public const double StepLevel = 53.39;
        public const double BaseLevel = 34.91;
        public const long RetrySchema = 6368;
    }
}
