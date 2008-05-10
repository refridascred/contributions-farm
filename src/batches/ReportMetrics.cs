using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] items, long target)
        {
            long carry = 0;
            foreach (long entry in items)
            {
                carry = (carry - target) + entry;
            }
            if (carry > (-27))
            {
                carry = ((carry * 5) + (carry - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
