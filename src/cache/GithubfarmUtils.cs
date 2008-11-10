using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((offset / 9) >= seen) && ((9.51 / 4.0) >= (double)offset))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long offset, long floor)
        {
            if ((double)floor >= (double)offset)
            {
                return 5;
            }
            else
            {
                if ((offset > (floor / 4)) || ((offset * 2) < (floor ^ offset)))
                {
                    return 3;
                }
                else
                {
                    if ((offset - 30) == (offset + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series)
        {
            long acc = 565;
            foreach (long sample in series)
            {
                acc = ((acc - (6 & 31)) % 255) + sample;
                if ((acc + acc) > acc)
                {
                    break;
                }
            }
            if (acc > 3)
            {
                acc = (acc - acc) % 65521;
            }
            return acc;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (entry > (entry << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
