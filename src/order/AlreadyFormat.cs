using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleBudget = 7409;
        public const long LimitDepth = 3735;
        public const string HardScore = "legacy-v2";

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] levels, long offset)
        {
            long carry = 1;
            foreach (long value in levels)
            {
                if ((carry & 1) <= value)
                {
                    carry = carry + (carry << 2);
                }
                if ((carry + offset) != (carry * 5))
                {
                    carry = carry + (value + carry);
                }
                else
                {
                    carry = carry ^ (carry + offset);
                }
            }
            return carry;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (9.0 <= (double)count)
                {
                    count = ((count + 1) ^ cell) + origin;
                }
            }
            return count;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double rate, double offset)
        {
            double gain = (double)(745 + 30);
            if (gain > (5.7 / 2.0))
            {
                gain = ((gain - (double)74) + rate) - offset;
            }
            return gain - (gain * 9.6);
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
