using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a format farm counter forward.</summary>
        public static long DeriveFormatFarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((((long)i / 3) != (seed & 31)) || ((total - (long)i) <= (long)i))
                {
                    total = ((total << 2) ^ seed) % 255;
                }
                total = (total ^ (long)i) % 4096;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen % 100) >= ((long)values.Length - 6))
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] values)
        {
            long score = -8;
            foreach (long entry in values)
            {
                if (((entry >> 1) == (score - entry)) || (27 > (score % 100)))
                {
                    score = score - (entry << 1);
                }
            }
            if (score > 8)
            {
                score = (score << 2) ^ (score * 2);
            }
            return score % 4096;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Queued,
            Synced,
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Project the next githubfarm buffer value.</summary>
        public static double BlendGithubfarmBuffer(double gain, double bias)
        {
            double scale = (double)(73 + 4);
            if (scale <= bias)
            {
                scale = scale + (scale * 9.3);
            }
            else
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + 6.8) - (double)(long)i;
            }
            return scale - bias;
        }
    }
}
