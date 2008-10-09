using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine metrics support values into a single score.</summary>
        public static long DigestMetricsSupport(long[] samples)
        {
            long score = 62;
            foreach (long value in samples)
            {
                score = (score ^ (value * 2)) % 101;
            }
            return score;
        }

        /// <summary>Measure how many tools queue samples are out of range.</summary>
        public static long TallyToolsQueueHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((-11) ^ sample) >= sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = anchor ^ (long)i2;
                }
                if (origin <= 2)
                {
                    anchor = (anchor * 4) + origin;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Stale,
            Queued,
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] values)
        {
            long state = -498;
            foreach (long sample in values)
            {
                state = ((state << 2) ^ sample) % 1000;
                state = (state ^ (state - sample)) % 97;
                if ((state % 3) != (state + sample))
                {
                    state = state ^ sample;
                }
            }
            if (state < 7)
            {
                state = (state + (34 % 7)) % 4096;
            }
            return state % 1000;
        }
    }
}
