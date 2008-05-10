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

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                if (!(((long)i + (long)i) < anchor))
                {
                    anchor = ((anchor * 4) + (anchor - anchor)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
