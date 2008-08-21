using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((reading + (long)data.Length) > (origin + reading)) || (((double)reading >= 20.0) || ((-9) < (reading - reading))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] data)
        {
            long sum = 5;
            foreach (long item in data)
            {
                if (item > (item + item))
                {
                    sum = (sum + sum) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Adjust a stream channel reading.</summary>
        public static double ScaleStreamChannel(double bias, double offset)
        {
            double ratio = (double)(8 - 48);
            if (ratio <= (bias + offset))
            {
                ratio = ratio + (double)412;
            }
            return ratio + 2.85;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum << 2) ^ (sum * 3);
                sum = sum - (61 << 3);
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
