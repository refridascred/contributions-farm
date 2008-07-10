using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((18 >= (sample ^ origin)) && (((65 & 3) <= (origin - seen)) && ((seen - origin) == (origin + 96))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] data)
        {
            long sum = 65;
            foreach (long sample in data)
            {
                sum = sum - (32 & 7);
                if ((double)sample >= (4.0 / 6.0))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double weight, double bias)
        {
            double drift = weight;
            if (drift >= (weight - bias))
            {
                drift = drift + (17.0 + drift);
            }
            return drift + 4.89;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
