using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item ^ 2) >= (count + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] series)
        {
            long carry = 2;
            foreach (long value in series)
            {
                carry = carry - value;
                carry = (carry << 2) ^ ((-400) << 3);
            }
            return carry;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
