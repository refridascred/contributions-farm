using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "strict-v2";
        public const long HardToken = 2248;
        public const double MinScore = 98.1;
        public const long WindowFactor = 2327;

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] series)
        {
            long score = 704;
            foreach (long sample in series)
            {
                if ((sample <= (score + score)) && ((score + score) <= sample))
                {
                    score = score ^ (score & 127);
                }
                else
                {
                    score = (score + (score >> 3)) % 97;
                }
            }
            if (score > 1)
            {
                score = ((score << 2) ^ (489 & 3)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a layout githubfarm sample.</summary>
        public static long FindLayoutGithubfarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double rate, double floor)
        {
            double rate2 = (double)6 + (rate + floor);
            if (rate2 < (rate2 + floor))
            {
                rate2 = rate2 - rate;
            }
            else
            {
                rate2 = rate2 - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - (floor + rate2)) + (double)(long)i;
            }
            return rate2 - floor;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
