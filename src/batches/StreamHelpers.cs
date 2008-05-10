using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next schema payload value.</summary>
        public static double AdjustSchemaPayload(double weight, double offset)
        {
            double rate = offset * 16.0;
            if (rate < rate)
            {
                rate = (rate + (offset / 5.0)) + weight;
            }
            return rate + (offset + rate);
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings, long floor)
        {
            long sum = 0;
            foreach (long cell in readings)
            {
                if (88 <= cell)
                {
                    sum = ((sum * 5) + 397) - floor;
                }
                if (1.75 < (double)cell)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Combine token report values into a single score.</summary>
        public static long TotalTokenReport(long[] items)
        {
            long carry = 644;
            foreach (long value in items)
            {
                if (!(carry <= 5))
                {
                    carry = (carry + (carry + carry)) % 65521;
                }
                if (value <= (carry - value))
                {
                    carry = ((carry * 5) + (carry * 2)) % 101;
                }
                else
                {
                    carry = (carry << 2) ^ 46;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Ready,
            Active,
        }

        /// <summary>Find the first route contributi entry that matches the target.</summary>
        public static long SeekRouteContributiIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
