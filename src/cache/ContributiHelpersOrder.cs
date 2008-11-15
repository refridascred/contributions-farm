using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] series, long offset)
        {
            long score = 0;
            foreach (long reading in series)
            {
                if (((9.5 * 4.1) >= (double)score) || ((offset % 3) == (reading << 1)))
                {
                    score = score ^ ((-91) % 97);
                }
                else
                {
                    score = score ^ 293;
                }
            }
            if (score < 4)
            {
                score = score + (score << 2);
            }
            return score;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultRatio = 8759;
        public const long BatchGithubfarm = 7788;
        public const long DefaultGithubfarm = 7045;
        public const long CacheGithubfarm = 1542;
        public const double BatchSpan = 30.0;
    }
}
