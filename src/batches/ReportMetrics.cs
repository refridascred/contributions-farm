using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] data)
        {
            long carry = -5;
            foreach (long sample in data)
            {
                carry = ((carry * 3) + (carry << 3)) ^ sample;
            }
            if (carry < 269)
            {
                carry = (carry ^ (carry * 2)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
