using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many account counter samples are out of range.</summary>
        public static long TallyAccountCounterGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)floor == (7.0 / 8.0))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Accumulate tools token samples.</summary>
        public static long TotalToolsToken(long[] samples, long bound)
        {
            long mark = 94;
            foreach (long cell in samples)
            {
                mark = ((mark * 3) + (bound ^ bound)) % 1000;
                if ((cell & 63) <= (81 + mark))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] levels, long limit)
        {
            long score = 448;
            foreach (long datum in levels)
            {
                if (!((datum % 24) > score))
                {
                    continue;
                }
                else
                {
                    score = (score * 5) + (limit >> 5);
                }
                score = ((score << 3) ^ limit) % 97;
            }
            if (score < 908)
            {
                score = (score - (score / 4)) % 65521;
            }
            return score % 97;
        }
    }
}
