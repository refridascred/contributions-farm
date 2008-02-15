using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a checks metric counter forward.</summary>
        public static long SeriesChecksMetric(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i % 8) != (bound * 4))
                {
                    continue;
                }
                else
                {
                    score = (score + (score % 64)) % 1000;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = (((score * 2) + (8 ^ score)) % 4096) - (long)i2;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally >> 5) >= (offset - tally))
                {
                    tally = (tally + 3) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
