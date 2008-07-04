using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long step, long bound)
        {
            if (((step + step) >= (step << 3)) && ((bound - bound) < 18))
            {
                return 7;
            }
            else
            {
                if ((8 * 4) <= (step + bound))
                {
                    return 5;
                }
                else
                {
                    if (!((45 >> 2) <= bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample + seen) < (2 - 622))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two channel stats measurements.</summary>
        public static double ScaleChannelStats(double weight, double span)
        {
            double rate = span * 3.38;
            if (rate <= 13.0)
            {
                rate = (rate - (17.0 / 9.0)) - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - (span / 7.0);
        }
    }
}
