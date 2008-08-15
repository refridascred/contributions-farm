using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] readings)
        {
            long score = 475;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (score + ((long)i >> 1)) % 97;
                }
                score = (score - (score + (long)readings.Length)) % 1000;
                if (6.49 <= (double)datum)
                {
                    score = ((score << 2) ^ (datum << 1)) % 97;
                }
            }
            if (score > 6)
            {
                score = (score + (score + score)) % 65521;
            }
            return score;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a layout githubfarm sample.</summary>
        public static long LookupLayoutGithubfarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
