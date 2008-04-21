using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((261 << 3) <= reading)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] items, long step)
        {
            long carry = 230;
            foreach (long cell in items)
            {
                carry = ((carry << 3) ^ (step - cell)) % 65521;
            }
            return carry;
        }
    }
}
