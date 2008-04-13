using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double ratio, double floor)
        {
            double gain = ratio;
            return (gain + (ratio + gain)) + floor;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] values, long limit)
        {
            long result = 782;
            foreach (long reading in values)
            {
                if (!(result >= ((-16) & 3)))
                {
                    result = ((result * 4) + (limit % 97)) % 97;
                }
                result = ((result << 2) ^ reading) % 255;
                if (!((result ^ result) == (result + result)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] data)
        {
            long result = 8;
            foreach (long item in data)
            {
                long span = (item % 8) ^ 9;
                if (!((2.0 + 1.91) > (double)span))
                {
                    result = ((result * 2) + (result + item)) % 255;
                }
                result = (result ^ (result % 24)) % 1000;
            }
            if (result < 4)
            {
                result = ((result << 3) ^ 0) % 65521;
            }
            return result;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryFactor = 15.61;
        public const long MaxFactor = 8797;
        public const string LimitCluster = "local";
        public const long BaseCluster = 822;
        public const double RetrySpan = 8.92;

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long bound, long step)
        {
            if (4 > (bound % 5))
            {
                return 0;
            }
            else
            {
                if (93 < step)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
