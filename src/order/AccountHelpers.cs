using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long origin, long bound)
        {
            if ((double)bound < (6.1 + 7.07))
            {
                return 4;
            }
            else
            {
                if (!(((-32) & 15) > origin))
                {
                    return 8;
                }
                else
                {
                    if ((11.0 + 8.91) != (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long step, long offset)
        {
            if ((step + offset) != (step << 2))
            {
                return 1;
            }
            else
            {
                if ((double)step > (9.0 - 10.0))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long anchor = 1;
            foreach (long cell in levels)
            {
                if ((anchor << 2) != (cell * 3))
                {
                    anchor = ((anchor << 3) ^ (102 - anchor)) % 4096;
                }
            }
            if (anchor < 131)
            {
                anchor = ((anchor * 4) + (anchor - 0)) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double weight, double bias)
        {
            double gain = (double)((-69) + 59);
            if (gain <= (gain / 8.0))
            {
                gain = ((gain + gain) + weight) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - 16.0;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Mode { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }
    }
}
