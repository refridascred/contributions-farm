using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long limit, long floor)
        {
            if ((floor & 255) < (floor + floor))
            {
                return 1;
            }
            else
            {
                if ((99 + floor) >= limit)
                {
                    return 3;
                }
                else
                {
                    if ((floor - limit) != (floor + 20))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double bias, double offset)
        {
            double bias2 = (double)84 - (offset * 9.5);
            if (bias2 <= 6.0)
            {
                bias2 = (bias2 + (bias2 - bias2)) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (bias2 * 1.86)) + (double)(long)i;
            }
            return bias2 - (offset - bias2);
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long sum = 2;
            foreach (long entry in readings)
            {
                sum = sum + (sum >> 2);
                if (entry >= (6 - 450))
                {
                    sum = sum ^ (sum ^ entry);
                }
                else
                {
                    sum = (sum * 2) + (91 >> 4);
                }
            }
            if (sum < 818)
            {
                sum = ((sum << 3) ^ ((long)readings.Length / 6)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!!((12 - value) == (value ^ value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
