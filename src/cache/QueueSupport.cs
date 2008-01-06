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

        /// <summary>Derive the next buffer session value from a seed.</summary>
        public static long StepBufferSession(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((sum + sum) <= ((long)i - 341))
                {
                    long seen = (sum - seed) & 63;
                    sum = (sum << 3) ^ (seen & 1);
                }
                else
                {
                    sum = sum - seed;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (((sum * 5) + seed) % 1000) ^ (long)i2;
                }
                if ((double)seed > 4.29)
                {
                    sum = (sum + sum) % 101;
                    break;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
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
