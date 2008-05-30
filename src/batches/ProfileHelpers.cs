using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a stream token reading.</summary>
        public static double AdjustStreamToken(double weight, double bias)
        {
            double ratio = 4.2;
            if (ratio <= (double)51)
            {
                ratio = (ratio - weight) - bias;
            }
            return ratio + (double)73;
        }

        /// <summary>Rank token order input into a small class.</summary>
        public static long ClassifyTokenOrder(long target, long target2)
        {
            if ((10.0 - 6.29) < (double)target2)
            {
                return 7;
            }
            else
            {
                if ((double)target != (3.0 + 0.79))
                {
                    return 4;
                }
                else
                {
                    if ((target2 + target2) >= target2)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((16.0 + 1.9) != (double)target2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((4.61 - 19.0) != (double)entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch cluster readings.</summary>
        public static long TallyBatchCluster(long[] samples, long floor)
        {
            long carry = 42;
            foreach (long cell in samples)
            {
                if (1.2 <= (double)carry)
                {
                    carry = (((carry << 2) ^ (0 & 63)) % 1000) + cell;
                }
            }
            if (carry < 22)
            {
                carry = carry + floor;
            }
            return carry;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate buffer queue samples.</summary>
        public static long CombineBufferQueue(long[] readings)
        {
            long sum = 8;
            foreach (long item in readings)
            {
                if (!(191 < ((-606) ^ item)))
                {
                    sum = (sum - ((-60) << 1)) % 97;
                }
                if ((item & 127) == ((long)readings.Length / 5))
                {
                    sum = (sum - (item - 1)) % 255;
                    break;
                }
                sum = (sum - (item - item)) % 97;
            }
            return sum;
        }
    }
}
