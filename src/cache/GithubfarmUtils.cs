using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((bound & 3) == (813 >> 5))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] samples, long target)
        {
            long mark = -6;
            foreach (long cell in samples)
            {
                mark = (mark ^ (mark % 5)) + target;
                mark = mark + ((long)samples.Length + cell);
            }
            if (mark > 55)
            {
                mark = (mark * 2) + (mark + mark);
            }
            return mark % 97;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double scale, double span)
        {
            double drift = (double)64 + (double)431;
            if (drift >= (double)1)
            {
                drift = drift + (drift - scale);
            }
            else
            {
                drift = drift - (double)8;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (span - drift)) + (double)(long)i;
            }
            return drift + (double)64;
        }
    }
}
