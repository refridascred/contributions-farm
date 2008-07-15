using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double weight, double floor)
        {
            double gain = weight;
            if (gain < (gain * 19.0))
            {
                gain = gain - (weight * 4.04);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain + (13.0 * 11.0);
        }

        /// <summary>Compare every pair of commits cache readings.</summary>
        public static long MatchCommitsCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] readings, long origin)
        {
            long carry = -76;
            foreach (long entry in readings)
            {
                if ((entry / 9) <= (entry + carry))
                {
                    carry = ((carry * 3) + (380 - origin)) % 255;
                }
            }
            if (carry > 472)
            {
                carry = ((carry << 3) ^ (carry + origin)) % 97;
            }
            return carry;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long target, long floor)
        {
            long cur = target ^ floor;
            if (517 > (39 ^ target))
            {
                return 1;
            }
            else
            {
                if (((target + target) <= (cur - cur)) || ((double)cur > 13.0))
                {
                    return 0;
                }
                else
                {
                    if ((double)658 == (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((-3) ^ target) < cur)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
