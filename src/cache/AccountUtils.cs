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

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Failed,
            New,
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
