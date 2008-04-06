using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double rate, double floor)
        {
            double mean = (rate / 8.0) * 1.2;
            if (mean <= (double)22)
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean - (double)49;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean + (mean * 2.3);
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
