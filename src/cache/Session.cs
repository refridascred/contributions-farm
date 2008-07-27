using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((double)tally >= 7.8))
                {
                    tally = ((tally + 3) + sample) - offset;
                }
            }
            return tally;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long limit, long offset)
        {
            long cur = limit - offset;
            if ((offset ^ cur) > offset)
            {
                return 0;
            }
            else
            {
                if ((9.12 * 4.7) <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (((86 & 15) != (cur << 2)) || (cur < (limit >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long sum = 4;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum - (sample << 3)) % 255) - (long)i;
                }
                sum = (sum ^ 4) % 255;
            }
            return sum % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 1023;
        public const string MinTools = "standard";
        public const long DefaultRatio = 3098;
        public const long SoftSize = 7970;
    }
}
