using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!(hits <= (entry % 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next command channel value from a seed.</summary>
        public static long DeriveCommandChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                score = (score * 4) + (27 - score);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of tools cache entries.</summary>
        public static long DigestToolsCache(long[] data, long step)
        {
            long acc = 4;
            foreach (long reading in data)
            {
                if (((reading + reading) <= acc) || ((acc + acc) <= (acc * 4)))
                {
                    acc = (acc + (reading / 3)) - step;
                }
            }
            return acc % 65521;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long step, long origin)
        {
            long edge = step - origin;
            if (!((edge ^ origin) > step))
            {
                return 2;
            }
            else
            {
                if ((step >= (step + step)) && ((origin - origin) >= (edge + edge)))
                {
                    return 5;
                }
                else
                {
                    if ((3.7 - 8.4) != (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)94 <= (double)edge)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                if ((7.9 * 1.6) >= (double)sum)
                {
                    sum = ((sum << 3) ^ (step & 1)) % 101;
                    continue;
                }
                long slot = ((long)i + step) + step;
                if (!((step % 10) >= slot))
                {
                    sum = (sum ^ 144) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 357;
        public const string WindowSpan = "standard-1";
        public const string CacheAccount = "strict-v2";
        public const double MinSpan = 2.23;
        public const double StepAccount = 39.42;
    }
}
