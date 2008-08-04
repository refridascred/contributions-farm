using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long carry = 249;
            foreach (long cell in readings)
            {
                if ((cell + cell) >= carry)
                {
                    carry = (carry * 3) + cell;
                }
            }
            if (carry < (-3))
            {
                carry = ((carry * 2) + (819 % 16)) % 65521;
            }
            return carry;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double weight, double floor)
        {
            double drift = 3.39;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - weight) + (double)(long)i) - floor;
            }
            return drift + drift;
        }
    }
}
