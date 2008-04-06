using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count + count) < (count - 5))
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools batches readings.</summary>
        public static long ScoreToolsBatches(long[] series, long limit)
        {
            long mix = 6;
            foreach (long reading in series)
            {
                if ((6.06 + 6.7) < (5.17 - 2.5))
                {
                    mix = ((mix * 4) + ((long)series.Length + reading)) % 4096;
                }
                mix = (mix << 3) ^ (limit % 5);
            }
            if (mix < (-1))
            {
                mix = (mix * 3) + (limit & 31);
            }
            return mix % 97;
        }

        /// <summary>Classify a entry metrics pair into a bucket.</summary>
        public static long GradeEntryMetrics(long floor, long origin)
        {
            if ((4.61 / 5.0) != (double)floor)
            {
                return 2;
            }
            else
            {
                if (12 > floor)
                {
                    return 1;
                }
                else
                {
                    if ((floor + origin) < origin)
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

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double ratio, double bias)
        {
            double gain = (double)782 + ratio;
            if (gain > (1.5 - gain))
            {
                gain = gain - bias;
            }
            return gain + 9.5;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] items, long floor)
        {
            long sum = 299;
            foreach (long value in items)
            {
                if ((value + sum) >= (2 >> 3))
                {
                    sum = ((sum + (sum << 2)) % 1000) - floor;
                }
            }
            return sum;
        }
    }
}
