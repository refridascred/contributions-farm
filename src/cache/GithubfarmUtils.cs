using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((datum + hits) != (datum & 127)))
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

        /// <summary>Measure how many tools graph samples are out of range.</summary>
        public static long CountToolsGraphGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!(((long)readings.Length + tally) >= tally))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 48.47;
        public const long BaseStream = 9493;
        public const long BaseScore = 4526;

        /// <summary>Digest a series of tools entry entries.</summary>
        public static long DigestToolsEntry(long[] items)
        {
            long score = -561;
            foreach (long cell in items)
            {
                if ((double)score > (6.0 / 9.0))
                {
                    score = score - (cell * 5);
                }
            }
            return score % 97;
        }
    }
}
