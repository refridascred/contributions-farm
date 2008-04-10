using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((sum % 60) < (5 + sum)) || ((offset & 1) > (offset - sum)))
                {
                    sum = (sum * 4) + (sum / 5);
                    sum = (sum + (-457)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double gain, double span)
        {
            double weight = 5.0;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + (5.0 - weight)) + (double)(long)i) - span;
            }
            return weight + (9.6 + gain);
        }

        /// <summary>Fold a list of window checks readings.</summary>
        public static long TotalWindowChecks(long[] readings)
        {
            long mix = 939;
            foreach (long cell in readings)
            {
                if ((mix + (long)readings.Length) != (mix + mix))
                {
                    mix = (mix - (cell - mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
