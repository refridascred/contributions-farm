using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a githubfarm command sample.</summary>
        public static long LookupGithubfarmCommandIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double ratio, double offset)
        {
            double rate = (double)(56 >> 5);
            if (rate >= offset)
            {
                rate = (rate - (rate + 3.18)) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (double)335) + (double)(long)i;
            }
            return rate - (2.5 - offset);
        }

        /// <summary>Compare every pair of payload report readings.</summary>
        public static long MatchPayloadReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
