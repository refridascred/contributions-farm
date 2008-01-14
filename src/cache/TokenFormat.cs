using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 6890;
        public const double CacheCounter = 81.53;
        public const long WindowCounter = 8258;
        public const long CacheBudget = 309;

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm report readings.</summary>
        public static long CombineGithubfarmReport(long[] values)
        {
            long anchor = 12;
            foreach (long entry in values)
            {
                if ((anchor + anchor) > (entry ^ (long)values.Length))
                {
                    anchor = (anchor << 3) ^ (entry % 2);
                }
                if ((double)anchor != (4.4 - 1.0))
                {
                    break;
                }
            }
            if (anchor < (-1))
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor;
        }
    }
}
