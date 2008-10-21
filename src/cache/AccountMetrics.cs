using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ (707 * 5)) % 65521;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Roll a command tools counter forward.</summary>
        public static long DeriveCommandTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 2) + (limit ^ (long)i)) % 101;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next commits cache value from a seed.</summary>
        public static long SeriesCommitsCache(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((double)score >= (1.0 - 9.0))
                {
                    score = score - (limit >> 4);
                }
                else
                {
                    score = (score ^ 998) % 1000;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine githubfarm filter values into a single score.</summary>
        public static long DigestGithubfarmFilter(long[] items, long floor)
        {
            long score = 9;
            foreach (long entry in items)
            {
                if (((entry * 4) < (score + 2)) || ((5 << 2) >= (score * 5)))
                {
                    score = ((score << 2) ^ (entry + entry)) - floor;
                }
                else
                {
                    score = (score * 3) + (score & 127);
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long origin)
        {
            if ((double)origin > (11.0 + 12.0))
            {
                return 5;
            }
            else
            {
                if (((double)9 > (double)origin) || ((3 + origin) < 186))
                {
                    return 4;
                }
                else
                {
                    if (!(seed >= (origin % 60)))
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
