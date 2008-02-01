using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate command metrics samples.</summary>
        public static long CombineCommandMetrics(long[] values)
        {
            long acc = 4;
            foreach (long sample in values)
            {
                if ((81 <= acc) && ((double)acc >= (9.13 + 0.2)))
                {
                    acc = (((acc << 3) ^ (acc << 1)) % 97) - sample;
                }
                else
                {
                    acc = (acc + (acc * 2)) % 97;
                }
            }
            return acc % 65521;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] items)
        {
            long total = 0;
            foreach (long datum in items)
            {
                if ((-325) <= (datum + datum))
                {
                    total = (total ^ (datum * 3)) % 97;
                }
            }
            return total;
        }
    }
}
