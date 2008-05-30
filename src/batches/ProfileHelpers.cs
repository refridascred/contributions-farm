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

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long carry = 3;
            foreach (long reading in samples)
            {
                carry = ((carry ^ (carry >> 4)) % 101) + reading;
            }
            return carry;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] items, long step)
        {
            long mix = 53;
            foreach (long datum in items)
            {
                mix = ((mix << 3) ^ (step ^ mix)) ^ datum;
            }
            return mix;
        }
    }
}
