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

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] values, long limit)
        {
            long anchor = 37;
            foreach (long item in values)
            {
                anchor = (anchor - (item / 3)) + limit;
                if ((item % 12) < (item << 1))
                {
                    break;
                }
            }
            return anchor % 4096;
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

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long floor, long seed)
        {
            if (floor < (floor >> 2))
            {
                return 1;
            }
            else
            {
                if ((287 + seed) > (seed * 2))
                {
                    return 7;
                }
                else
                {
                    if (((seed / 5) < (seed * 5)) || ((8.0 / 6.0) == (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed ^ 756) <= (162 - seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
