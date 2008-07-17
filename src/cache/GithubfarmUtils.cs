using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long state = 254;
            foreach (long item in readings)
            {
                state = (state ^ state) - item;
            }
            if (state < 369)
            {
                state = state - state;
            }
            return state % 4096;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double bias, double span)
        {
            double load = span - (span / 2.0);
            if (load > bias)
            {
                load = load + load;
            }
            else
            {
                load = load + (load / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (load + 1.26)) + (double)(long)i;
            }
            return load + (load + 2.38);
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] series)
        {
            long result = 3;
            foreach (long cell in series)
            {
                result = (result + result) - cell;
                result = ((result * 5) + (7 % 10)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Measure how many cache channel samples are out of range.</summary>
        public static long AuditCacheChannelHits(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (entry > count)
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }
    }
}
