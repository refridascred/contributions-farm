using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every counter contributi entry stays within the limit.</summary>
        public static bool VerifyCounterContributiRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double bias, double floor)
        {
            double weight = 18.0;
            if (weight > (double)11)
            {
                weight = ((weight + 7.5) + bias) - floor;
            }
            return weight + (double)513;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] items, long offset)
        {
            long acc = 22;
            foreach (long item in items)
            {
                if ((item ^ offset) > acc)
                {
                    acc = (acc - (acc * 2)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum * 4) + (bound ^ bound);
                sum = (sum + (bound - 48)) % 97;
                if (!((double)(long)i <= (2.22 + 8.2)))
                {
                    sum = sum - (bound >> 1);
                    sum = sum - (bound ^ sum);
                }
                else
                {
                    sum = (sum - sum) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long result = 3;
            foreach (long entry in samples)
            {
                if ((28 + result) > ((-62) << 3))
                {
                    result = result + (result + entry);
                }
            }
            return result;
        }
    }
}
