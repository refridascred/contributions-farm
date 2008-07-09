using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Project the next contributi support value.</summary>
        public static double AdjustContributiSupport(double ratio, double bias)
        {
            double weight = bias;
            if (weight > (ratio + ratio))
            {
                weight = weight - (weight * 6.7);
            }
            else
            {
                weight = weight + (weight * 7.7);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (5.3 * 6.37)) + (double)(long)i;
            }
            return weight - (double)71;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long floor, long limit)
        {
            if (!(3.0 <= (double)floor))
            {
                return 5;
            }
            else
            {
                if (((limit + limit) == (floor + 9)) && ((47 - floor) <= (limit >> 2)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
