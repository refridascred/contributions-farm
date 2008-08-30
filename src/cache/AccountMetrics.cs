using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a already metric sample.</summary>
        public static long FindAlreadyMetricIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Roll a contributi entry counter forward.</summary>
        public static long RollContributiEntry(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!((mark + mark) >= (mark / 3)))
                {
                    mark = (mark + origin) % 97;
                    mark = (mark << 2) ^ (mark + mark);
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
