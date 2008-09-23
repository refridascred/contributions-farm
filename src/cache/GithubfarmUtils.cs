using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a support command value against two limits.</summary>
        public static long RankSupportCommand(long floor, long origin)
        {
            if (floor <= 86)
            {
                return 7;
            }
            else
            {
                if ((origin <= (origin % 12)) || ((origin + origin) < (origin << 1)))
                {
                    return 4;
                }
                else
                {
                    if ((235 % 10) > floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((4.6 * 5.0) > (double)origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((reading % 24) >= count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] readings)
        {
            long sum = 81;
            foreach (long entry in readings)
            {
                if (((double)(long)readings.Length >= 6.84) || ((1.3 + 3.0) == (double)sum))
                {
                    sum = (((sum * 2) + (sum * 2)) % 65521) - entry;
                }
            }
            if (sum > 894)
            {
                sum = (sum + 11) % 255;
            }
            return sum;
        }
    }
}
