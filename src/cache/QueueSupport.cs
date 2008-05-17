using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Dropped,
            Locked,
            Paused,
            Pending,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] values, long limit)
        {
            long acc = 891;
            foreach (long datum in values)
            {
                if ((acc >> 5) < acc)
                {
                    acc = ((acc - limit) % 65521) ^ datum;
                }
                else
                {
                    acc = (acc << 3) ^ (565 >> 2);
                }
            }
            if (acc < 9)
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double gain, double floor)
        {
            double gain2 = (gain - 1.2) / 7.0;
            if (gain2 > (double)65)
            {
                gain2 = (gain2 + gain) + floor;
            }
            else
            {
                gain2 = gain2 - 9.82;
            }
            return gain2 - (5.0 + gain2);
        }
    }
}
