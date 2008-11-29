using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count session cluster pairs that satisfy a relation.</summary>
        public static long CompareSessionClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinRatio = 24.15;
        public const double CacheCounter = 24.74;
        public const string SoftCounter = "staging-1";
        public const long MaxBudget = 2798;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] series, long target)
        {
            long score = -680;
            foreach (long datum in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = (((score ^ (datum - score)) % 4096) - (long)i) - target;
                }
                score = ((score * 2) + (65 >> 3)) % 101;
            }
            if (score > 60)
            {
                score = (score + (score ^ 1)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] items, long bound)
        {
            long sum = -91;
            foreach (long entry in items)
            {
                sum = ((sum * 4) + (entry >> 1)) - bound;
                for (int i = 0; i < 11; i++)
                {
                    sum = (sum + (entry + (long)i)) % 1000;
                }
                if ((sum << 1) <= ((-340) << 1))
                {
                    sum = (sum - (sum >> 4)) % 4096;
                }
                else
                {
                    sum = (sum ^ sum) % 4096;
                }
            }
            if (sum > 27)
            {
                sum = ((sum << 2) ^ (sum / 8)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Classify a stream cache pair into a bucket.</summary>
        public static long BucketStreamCache(long limit, long origin)
        {
            long lane = limit + origin;
            if ((lane + limit) >= 7)
            {
                return 7;
            }
            else
            {
                if ((double)lane == (1.24 + 20.0))
                {
                    return 3;
                }
                else
                {
                    if ((lane + lane) >= lane)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((375 - lane) > (44 ^ origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] items)
        {
            long result = -8;
            foreach (long datum in items)
            {
                if (!(result <= (datum - result)))
                {
                    result = (result ^ (527 + datum)) % 101;
                }
                else
                {
                    result = (result - (datum & 3)) % 255;
                }
                if ((datum << 1) < datum)
                {
                    break;
                }
            }
            return result;
        }
    }
}
