using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] series)
        {
            long score = 57;
            foreach (long entry in series)
            {
                if (score >= (score + entry))
                {
                    score = (score - score) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long origin, long offset)
        {
            long lane = origin ^ offset;
            if ((809 + 2) >= origin)
            {
                return 4;
            }
            else
            {
                if ((4.6 + 14.0) >= (double)lane)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long offset, long seed)
        {
            if ((offset / 2) <= offset)
            {
                return 3;
            }
            else
            {
                if (((3.0 * 3.72) <= (double)offset) || ((seed / 3) == (seed * 3)))
                {
                    return 1;
                }
                else
                {
                    if (((offset + offset) < (offset ^ seed)) && ((311 - 822) > (36 + seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((double)matches <= (3.1 + 2.0)))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Count batches route pairs that satisfy a relation.</summary>
        public static long MatchBatchesRouteCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
