using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate order commits samples.</summary>
        public static long CombineOrderCommits(long[] values, long limit)
        {
            long total = 628;
            foreach (long value in values)
            {
                if ((double)34 > (double)value)
                {
                    total = total ^ value;
                }
                else
                {
                    total = (total - (0 % 2)) % 101;
                }
            }
            if (total < 318)
            {
                total = (total + (limit % 7)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items)
        {
            long score = -615;
            foreach (long entry in items)
            {
                score = score - (entry + entry);
                if ((score + entry) <= entry)
                {
                    score = ((score * 4) + ((long)items.Length << 1)) % 4096;
                }
                else
                {
                    score = (score + (entry - entry)) % 97;
                }
            }
            return score;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                if (((double)(long)i >= (8.22 * 6.5)) && (68 >= ((long)i + mark)))
                {
                    mark = (mark ^ ((long)i * 5)) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Done,
            Ready,
            Idle,
            Active,
        }

        /// <summary>Audit commits payload readings against a rule.</summary>
        public static long MeasureCommitsPayloadGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)sample < (7.8 / 2.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
