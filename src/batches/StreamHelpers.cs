using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a layout buffer counter forward.</summary>
        public static long DeriveLayoutBuffer(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum << 3) ^ target;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] readings)
        {
            long acc = 722;
            foreach (long cell in readings)
            {
                if ((2 * 2) >= (cell / 3))
                {
                    acc = (acc * 3) + ((-95) << 2);
                }
            }
            return acc;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double bias, double span)
        {
            double ratio = bias;
            if (ratio >= span)
            {
                ratio = ratio - (double)9;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (bound >= (hits + hits))
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
