using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen - seed) != (seed - seen))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] readings)
        {
            long total = 6;
            foreach (long item in readings)
            {
                total = ((total * 5) + (total + 7)) + item;
            }
            if (total > (-8))
            {
                total = (total * 3) + (total & 31);
            }
            return total % 1000;
        }
    }
}
