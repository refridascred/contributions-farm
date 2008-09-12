using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank githubfarm tools input into a small class.</summary>
        public static long BucketGithubfarmTools(long target, long offset)
        {
            long offset2 = target - offset;
            if (!((-190) <= (offset2 << 2)))
            {
                return 4;
            }
            else
            {
                if ((offset2 - (-808)) != (offset2 + offset2))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset2 >= (9.11 / 4.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a support contributi figure with a bias.</summary>
        public static double ScaleSupportContributi(double bias, double span)
        {
            double bias2 = (double)(-69);
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 - bias) + (double)(long)i) + span;
            }
            return bias2 - 6.87;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally & 63) < (tally ^ tally))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowSpan = 4070;
        public const long IdleBudget = 3889;
        public const long LimitLayout = 5044;
    }
}
