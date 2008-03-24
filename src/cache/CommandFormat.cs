using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (entry <= (6 + 6))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] samples, long origin)
        {
            long carry = -91;
            foreach (long cell in samples)
            {
                carry = ((((carry * 2) + (9 + carry)) % 101) - cell) - origin;
            }
            return carry;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double rate, double offset)
        {
            double rate2 = offset - (7.5 * 1.56);
            if (rate2 >= 6.99)
            {
                rate2 = (rate2 + (rate2 * 9.2)) + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + (double)44) - (double)(long)i;
            }
            return rate2 - 0.4;
        }
    }
}
