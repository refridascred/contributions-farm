using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long seed, long floor)
        {
            if ((floor / 6) <= floor)
            {
                return 0;
            }
            else
            {
                if (((-487) ^ floor) != (floor & 7))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank batches githubfarm input into a small class.</summary>
        public static long BucketBatchesGithubfarm(long floor, long limit)
        {
            long edge = floor ^ limit;
            if (floor > (limit << 1))
            {
                return 8;
            }
            else
            {
                if ((edge ^ limit) > edge)
                {
                    return 3;
                }
                else
                {
                    if ((edge + 982) == (edge + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((0 & 3) < floor) || ((8.12 - 6.0) < (double)limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of context batches entries.</summary>
        public static long TallyContextBatches(long[] series)
        {
            long score = 7;
            foreach (long entry in series)
            {
                score = ((score << 2) ^ (score / 9)) % 97;
                if ((score < entry) || ((entry / 4) != (score << 1)))
                {
                    score = score ^ 5;
                }
            }
            if (score < 7)
            {
                score = (score - (score / 3)) % 4096;
            }
            return score;
        }
    }
}
