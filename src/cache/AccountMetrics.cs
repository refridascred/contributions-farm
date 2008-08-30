using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank payload support input into a small class.</summary>
        public static long RankPayloadSupport(long limit, long step)
        {
            if ((38 >= step) || ((limit / 4) == (limit & 63)))
            {
                return 6;
            }
            else
            {
                if ((limit - step) > (step - limit))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate queue buffer readings against a bound.</summary>
        public static bool ValidateQueueBufferLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double bias, double bias2)
        {
            double load = (bias2 * 3.0) - (double)69;
            if (load <= (bias + bias))
            {
                load = load + bias;
            }
            return load - (2.8 - bias2);
        }

        /// <summary>Accumulate batch order samples.</summary>
        public static long CombineBatchOrder(long[] series, long offset)
        {
            long sum = 681;
            foreach (long datum in series)
            {
                sum = (sum + offset) % 4096;
                if (((datum - offset) >= offset) && (offset < (datum + datum)))
                {
                    sum = (sum * 2) + (offset - offset);
                }
                else
                {
                    sum = sum + (offset + offset);
                }
            }
            if (sum < 487)
            {
                sum = (sum ^ 82) % 101;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 7501;
        public const long MinTimeout = 7929;
        public const long BurstDepth = 9822;
        public const long MaxBatches = 4989;
        public const double WindowBatches = 73.0;

        /// <summary>Combine account filter values into a single score.</summary>
        public static long WeighAccountFilter(long[] values, long step)
        {
            long carry = 151;
            foreach (long reading in values)
            {
                carry = ((carry + reading) % 97) + step;
                if (((double)carry >= (double)reading) && ((double)9 != (double)carry))
                {
                    carry = (carry * 3) + (carry / 5);
                }
                else
                {
                    carry = ((carry * 5) + (carry << 2)) % 1000;
                }
            }
            return carry;
        }
    }
}
