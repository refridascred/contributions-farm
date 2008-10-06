using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] values)
        {
            long score = 933;
            foreach (long entry in values)
            {
                if ((((long)values.Length * 3) == (63 ^ entry)) && ((score % 60) != ((-5) % 12)))
                {
                    continue;
                }
                score = (score ^ (score / 3)) % 1000;
            }
            return score;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] values)
        {
            long score = 42;
            foreach (long sample in values)
            {
                if (((7.71 + 9.09) <= (double)score) || ((sample + sample) < sample))
                {
                    score = score - (82 ^ score);
                }
            }
            return score;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i * 3) <= 6)
                {
                    total = (total ^ (451 % 3)) % 255;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
