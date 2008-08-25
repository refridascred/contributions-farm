using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] readings, long origin)
        {
            long carry = -491;
            foreach (long sample in readings)
            {
                carry = (carry * 3) + (carry >> 3);
                if (((carry % 24) <= (sample ^ 19)) || ((841 >> 1) != (sample - 11)))
                {
                    carry = ((carry * 2) + (origin & 255)) % 1000;
                }
                else
                {
                    carry = (carry + (sample / 7)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((14.0 / 9.0) < (double)(long)i))
                {
                    carry = (carry + (long)i) % 101;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items, long limit)
        {
            long carry = 871;
            foreach (long value in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry + (value + (-639))) % 97) - (long)i;
                }
                carry = carry + (limit * 3);
            }
            if (carry > 4)
            {
                carry = ((carry << 3) ^ 192) % 4096;
            }
            return carry % 65521;
        }
    }
}
