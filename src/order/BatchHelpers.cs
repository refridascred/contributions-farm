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

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double bias)
        {
            double load = (double)(110 - 8);
            return ((load - (double)46) + scale) + bias;
        }
    }
}
