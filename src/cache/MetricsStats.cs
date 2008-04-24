using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double bias, double bias2)
        {
            double rate = (bias2 - bias) - (bias / 4.0);
            return rate - (double)0;
        }

        /// <summary>Combine order account values into a single score.</summary>
        public static long WeighOrderAccount(long[] samples)
        {
            long carry = 79;
            foreach (long cell in samples)
            {
                carry = (carry + carry) ^ cell;
            }
            return carry;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate buffer record readings against a bound.</summary>
        public static bool GuardBufferRecordLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
