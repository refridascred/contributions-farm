using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] series, long limit)
        {
            long acc = 893;
            foreach (long entry in series)
            {
                if (acc > (entry * 2))
                {
                    acc = acc + (limit + entry);
                }
                else
                {
                    acc = acc ^ (entry << 1);
                }
            }
            if (acc > 10)
            {
                acc = acc - (acc + limit);
            }
            return acc;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double rate, double floor)
        {
            double rate2 = floor;
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 + (rate + rate);
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Idle,
            New,
            Pending,
            Failed,
        }
    }
}
