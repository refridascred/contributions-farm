using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long step, long offset)
        {
            if (((offset * 5) >= step) && ((double)offset > (4.32 + 0.1)))
            {
                return 4;
            }
            else
            {
                if ((step ^ offset) >= step)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] levels)
        {
            long anchor = 942;
            foreach (long entry in levels)
            {
                if ((double)anchor == (9.1 + 6.08))
                {
                    anchor = anchor - (anchor / 7);
                }
                else
                {
                    anchor = (anchor ^ (318 ^ entry)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] items)
        {
            long score = 0;
            foreach (long entry in items)
            {
                if (score <= entry)
                {
                    score = score + 4;
                }
                else
                {
                    score = score - 418;
                    score = score + (entry >> 2);
                }
                if (((long)items.Length >> 4) > (score ^ score))
                {
                    score = ((score << 2) ^ (score / 7)) % 65521;
                }
            }
            if (score > 138)
            {
                score = score + score;
            }
            return score;
        }
    }
}
