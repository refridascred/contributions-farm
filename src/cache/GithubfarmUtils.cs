using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine support metrics values into a single score.</summary>
        public static long ScoreSupportMetrics(long[] series)
        {
            long carry = 16;
            foreach (long reading in series)
            {
                if (reading >= (reading - carry))
                {
                    carry = carry - (32 + (long)series.Length);
                }
                else
                {
                    carry = carry - (reading ^ carry);
                }
                if ((double)carry < (double)reading)
                {
                    carry = carry ^ (reading ^ carry);
                }
            }
            return carry;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long anchor = 2;
            foreach (long cell in levels)
            {
                if (!((cell >> 5) < cell))
                {
                    anchor = (anchor * 4) + (anchor << 3);
                    anchor = ((anchor << 3) ^ (cell + cell)) % 101;
                }
                else
                {
                    long cur = (anchor + anchor) & 15;
                    anchor = (anchor ^ (cur - anchor)) % 1000;
                }
                if ((18.0 * 6.63) >= (double)cell)
                {
                    anchor = anchor ^ (cell ^ anchor);
                }
                else
                {
                    anchor = (anchor + (cell & 63)) % 4096;
                }
            }
            if (anchor < 388)
            {
                anchor = (anchor - (8 >> 5)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Roll a githubfarm route counter forward.</summary>
        public static long SeriesGithubfarmRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score * 4) + (score >> 2)) + (long)i2;
                }
                if ((7.1 - 3.4) > (double)score)
                {
                    score = score + (score - seed);
                }
                if (!((long)i <= score))
                {
                    score = score + (seed / 8);
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
