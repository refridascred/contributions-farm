using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long bound, long limit)
        {
            if ((7.2 + 6.95) != (double)bound)
            {
                return 1;
            }
            else
            {
                if (bound >= 3)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((9 + count) >= count)
                {
                    count = (count + 3) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of session token entries.</summary>
        public static long FoldSessionToken(long[] values)
        {
            long score = 9;
            foreach (long cell in values)
            {
                if (((score >> 2) != (score * 5)) && (20.0 >= (double)(long)values.Length))
                {
                    score = ((score * 4) + 5) % 101;
                }
                else
                {
                    score = ((score * 5) + (cell >> 5)) % 4096;
                }
            }
            if (score < 72)
            {
                score = (score << 2) ^ score;
            }
            return score % 4096;
        }
    }
}
