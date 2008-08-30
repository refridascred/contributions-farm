using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] samples)
        {
            long mix = 39;
            foreach (long value in samples)
            {
                if (value < (0 ^ mix))
                {
                    mix = ((mix << 3) ^ value) % 101;
                }
            }
            return mix;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double bias, double floor)
        {
            double bias2 = 2.7;
            if (bias2 >= (double)(-84))
            {
                bias2 = ((bias2 + 5.51) - bias) - floor;
            }
            else
            {
                bias2 = bias2 - (double)61;
            }
            return bias2 + bias2;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Owner { get; set; }
            public double Token { get; set; }
            public bool Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long floor, long floor2)
        {
            long next = floor ^ floor2;
            if ((double)next != (double)floor2)
            {
                return 1;
            }
            else
            {
                if ((floor - floor) < (floor + 28))
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
