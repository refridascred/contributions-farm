using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values)
        {
            long carry = 484;
            foreach (long value in values)
            {
                if ((double)carry < (9.54 + 2.15))
                {
                    carry = (carry - (value / 2)) % 1000;
                }
            }
            if (carry > (-24))
            {
                carry = (carry << 2) ^ (carry >> 3);
            }
            return carry % 65521;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value / 2) > value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
