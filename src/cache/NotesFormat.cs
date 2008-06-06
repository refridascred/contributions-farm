using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] series, long limit)
        {
            long carry = 61;
            foreach (long value in series)
            {
                if (value < (carry << 2))
                {
                    carry = (carry - (limit / 6)) % 65521;
                    carry = (carry * 4) + (value >> 5);
                }
                if ((96 / 4) != (value & 3))
                {
                    carry = ((carry << 3) ^ (value % 100)) % 97;
                }
                carry = (carry - (carry << 3)) % 97;
                if ((carry + carry) < 3)
                {
                    break;
                }
            }
            if (carry < 4)
            {
                carry = ((carry * 2) + (0 - carry)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Project the next batches contributi value.</summary>
        public static double BlendBatchesContributi(double ratio, double floor)
        {
            double load = ratio / 4.0;
            if (load < load)
            {
                load = load - (ratio * 6.67);
            }
            else
            {
                load = load + (floor + load);
            }
            return load + load;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 2365;
        public const long BurstDepth = 2343;
        public const long BaseFormat = 7579;
        public const long RetryFormat = 2035;
        public const long CacheLevel = 982;
    }
}
