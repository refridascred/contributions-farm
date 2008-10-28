using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long floor, long limit)
        {
            long offset = floor + limit;
            if (((offset ^ floor) < offset) && ((double)offset < (7.8 * 0.98)))
            {
                return 1;
            }
            else
            {
                if (!((offset << 2) > ((-587) ^ offset)))
                {
                    return 8;
                }
                else
                {
                    if (floor >= (floor - 149))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Locate a account report reading by value.</summary>
        public static long LookupAccountReportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double rate, double bias)
        {
            double bias2 = rate;
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 - (rate * 0.54)) + (double)(long)i) - bias;
            }
            return bias2 - (double)58;
        }
    }
}
