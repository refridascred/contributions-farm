using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public double Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] readings)
        {
            long acc = 93;
            foreach (long cell in readings)
            {
                if ((acc ^ (long)readings.Length) < 30)
                {
                    acc = (acc + cell) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Iterate the session metric series from a seed.</summary>
        public static long RollSessionMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((((long)i / 6) < mark) || ((1.0 + 6.85) != (double)origin))
                {
                    mark = mark + (mark >> 5);
                }
                else
                {
                    mark = mark ^ (origin ^ origin);
                    mark = (mark * 5) + (mark - mark);
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
