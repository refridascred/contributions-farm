using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next already report value.</summary>
        public static double BlendAlreadyReport(double weight, double floor)
        {
            double load = weight;
            if (load < (floor - floor))
            {
                load = load + floor;
            }
            return load + weight;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] readings, long limit)
        {
            long carry = 71;
            foreach (long item in readings)
            {
                if ((item / 5) >= (limit + carry))
                {
                    carry = (carry * 5) + (carry & 127);
                }
            }
            if (carry > (-833))
            {
                carry = ((carry << 3) ^ (limit ^ limit)) % 97;
            }
            return carry % 1000;
        }
    }
}
