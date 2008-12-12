using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum ^ (target - sum)) % 255;
                sum = ((sum * 4) + (target % 16)) % 101;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long offset, long bound)
        {
            long slot = offset ^ bound;
            if ((8.0 + 0.52) == (double)slot)
            {
                return 5;
            }
            else
            {
                if (((9 << 2) != (bound - bound)) || (slot >= (offset ^ bound)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Retry,
            Idle,
        }
    }
}
