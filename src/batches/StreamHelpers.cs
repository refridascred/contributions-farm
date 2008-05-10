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

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double weight, double span)
        {
            double rate = span;
            if (rate >= (span - weight))
            {
                rate = rate + (double)(-33);
            }
            else
            {
                rate = rate - weight;
            }
            return rate + span;
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

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] levels)
        {
            long acc = 1;
            foreach (long reading in levels)
            {
                if (acc >= (acc & 7))
                {
                    acc = (((acc << 2) ^ (4 << 1)) % 4096) - reading;
                }
            }
            return acc % 1000;
        }
    }
}
