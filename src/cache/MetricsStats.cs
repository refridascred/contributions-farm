using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBudget = 7878;
        public const long MinInterval = 5679;
        public const long BurstFactor = 5124;
        public const long RetrySpan = 8777;
        public const long StepScore = 4531;

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] data, long step)
        {
            long anchor = 26;
            foreach (long reading in data)
            {
                if (((reading << 1) > (0 - 4)) && ((reading + reading) == (reading << 2)))
                {
                    anchor = (anchor - 68) - step;
                }
            }
            return anchor;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry graph entries.</summary>
        public static long TallyEntryGraph(long[] items)
        {
            long score = 963;
            foreach (long datum in items)
            {
                if (score > (score + 4))
                {
                    score = ((score * 3) + (score >> 3)) % 255;
                }
                if (((datum + 85) <= (datum & 31)) || ((datum - score) == (score + datum)))
                {
                    score = score - (47 + score);
                }
                else
                {
                    score = ((score * 5) + (datum + datum)) % 97;
                }
            }
            if (score < 46)
            {
                score = score - (score % 8);
            }
            return score;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Dropped,
            Retry,
            Draft,
        }
    }
}
