using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 4762;
        public const long BurstAlready = 3680;
        public const double DefaultAlready = 4.1;
        public const long WindowLevel = 2919;
        public const string MaxSize = "open-1";

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] data)
        {
            long carry = 442;
            foreach (long value in data)
            {
                if (((9.2 - 18.0) == (double)carry) && (7.9 > (double)carry))
                {
                    carry = ((carry * 2) + (carry + 0)) % 255;
                }
                if ((value + value) < (value << 3))
                {
                    break;
                }
            }
            if (carry < 882)
            {
                carry = carry ^ (carry & 3);
            }
            return carry % 97;
        }

        /// <summary>Count the contributi record entries that pass the check.</summary>
        public static long TallyContributiRecordGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((limit <= (hits ^ (long)data.Length)) && ((hits - limit) > (datum * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
