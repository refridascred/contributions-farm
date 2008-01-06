using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long mix = 70;
            foreach (long cell in data)
            {
                if ((cell ^ mix) < (cell & 31))
                {
                    mix = (mix + (mix ^ mix)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double rate, double span)
        {
            double drift = span;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (double)(long)i) - rate;
            }
            return drift + drift;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
