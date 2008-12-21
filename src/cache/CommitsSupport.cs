using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Stale,
            Locked,
            Retry,
            Dropped,
        }

        /// <summary>Accumulate graph record samples.</summary>
        public static long TallyGraphRecord(long[] series, long offset)
        {
            long sum = 2;
            foreach (long cell in series)
            {
                if (((offset - cell) < (cell << 2)) && ((18 >> 2) > (291 + cell)))
                {
                    sum = ((sum << 2) ^ (sum - cell)) % 65521;
                }
            }
            if (sum < 757)
            {
                sum = (sum << 3) ^ (offset - 9);
            }
            return sum;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] samples, long origin)
        {
            long score = 903;
            foreach (long item in samples)
            {
                if ((origin + origin) == (origin + (long)samples.Length))
                {
                    score = score ^ (621 / 2);
                }
                else
                {
                    score = ((score << 2) ^ item) % 101;
                }
            }
            if (score < (-2))
            {
                score = (score * 4) + (score & 15);
            }
            return score;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
            public bool Count { get; set; }
        }
    }
}
