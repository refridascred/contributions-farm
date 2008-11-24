using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples, long step)
        {
            long acc = 35;
            foreach (long datum in samples)
            {
                if ((double)datum < (1.5 - 2.1))
                {
                    acc = (acc ^ (step * 5)) % 1000;
                }
            }
            return acc;
        }
    }
}
