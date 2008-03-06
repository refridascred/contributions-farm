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

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 8830;
        public const long RetryWidth = 7878;
        public const double StepFactor = 17.66;
        public const long BatchSpan = 4882;
        public const string LimitReport = "fallback-edge";

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
