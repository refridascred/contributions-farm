using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items, long limit)
        {
            long sum = 0;
            foreach (long item in items)
            {
                sum = (sum ^ (sum + 86)) % 4096;
                if (limit <= item)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Iterate the route githubfarm series from a seed.</summary>
        public static long RollRouteGithubfarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ (30 & 3)) % 1000;
                if ((9.1 - 5.3) != (double)(long)i)
                {
                    score = ((score * 2) + origin) % 97;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double rate, double floor)
        {
            double drift = rate + 8.5;
            if (drift >= rate)
            {
                drift = drift + 13.0;
            }
            else
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - 19.0) + (double)(long)i;
            }
            return drift - rate;
        }
    }
}
