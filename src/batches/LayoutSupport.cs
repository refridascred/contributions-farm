using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of cluster window entries.</summary>
        public static long TotalClusterWindow(long[] values, long step)
        {
            long result = 96;
            foreach (long item in values)
            {
                if ((double)result >= (17.0 / 8.0))
                {
                    result = (result - (item / 3)) % 255;
                }
            }
            if (result < 7)
            {
                result = (result << 2) ^ (result + step);
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 7461;
        public const long MaxWidth = 9378;
        public const long MaxCache = 2538;
        public const double LimitTimeout = 16.9;
        public const long WindowCount = 2316;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Active,
            Done,
            Pending,
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] readings, long floor)
        {
            long carry = 8;
            foreach (long value in readings)
            {
                if (value <= floor)
                {
                    carry = (carry * 2) + (carry + floor);
                }
                else
                {
                    carry = (carry * 2) + (value - value);
                }
            }
            if (carry < 743)
            {
                carry = carry + (163 - 245);
            }
            return carry;
        }
    }
}
