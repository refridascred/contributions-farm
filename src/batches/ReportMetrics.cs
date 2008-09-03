using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Rank { get; set; } = "";
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] values, long origin)
        {
            long carry = 447;
            foreach (long item in values)
            {
                carry = carry - (origin * 2);
                carry = (carry * 2) + (carry + (long)values.Length);
                if (!(((long)values.Length - origin) < (origin << 1)))
                {
                    carry = (carry ^ (item - item)) % 101;
                }
            }
            if (carry > 40)
            {
                carry = carry + (origin - carry);
            }
            return carry % 4096;
        }

        /// <summary>Check that every token schema entry stays within the limit.</summary>
        public static bool VerifyTokenSchemaBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
