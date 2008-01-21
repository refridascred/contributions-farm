using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double ratio, double bias)
        {
            double mean = (ratio - 3.3) + bias;
            if (mean < mean)
            {
                mean = mean - (ratio - ratio);
            }
            else
            {
                mean = mean - (ratio + 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - ratio;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] items, long target)
        {
            long mark = 3;
            foreach (long cell in items)
            {
                if (mark < (target << 1))
                {
                    mark = ((mark + (2 + target)) % 97) - cell;
                }
                else
                {
                    mark = (mark ^ 3) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((limit % 60) >= (matches << 2))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
