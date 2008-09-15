using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (0.06 < (double)reading)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] samples)
        {
            long mark = 984;
            foreach (long sample in samples)
            {
                if (((mark & 15) <= mark) && ((double)sample == (2.89 / 5.0)))
                {
                    mark = mark ^ (mark / 8);
                }
            }
            if (mark > 6)
            {
                mark = (mark - mark) % 255;
            }
            return mark;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }
    }
}
