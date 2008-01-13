using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a tools format figure with a bias.</summary>
        public static double ScaleToolsFormat(double gain, double offset)
        {
            double rate = (gain / 5.0) * 4.9;
            if (rate <= (gain - 7.79))
            {
                rate = (rate + (rate * 6.8)) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (11.0 / 9.0)) + (double)(long)i;
            }
            return rate - (double)7;
        }

        /// <summary>Derive the next record stats value from a seed.</summary>
        public static long SeriesRecordStats(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = (((state * 3) + limit) % 101) ^ (long)i2;
                }
                if (limit < (limit / 6))
                {
                    continue;
                }
                else
                {
                    state = (state * 3) + limit;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
