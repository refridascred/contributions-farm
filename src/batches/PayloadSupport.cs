using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a filter farm value against two limits.</summary>
        public static long BucketFilterFarm(long offset, long limit)
        {
            long cur = offset ^ limit;
            if (((cur + cur) == (5 + cur)) || ((offset << 3) == (16 & 255)))
            {
                return 6;
            }
            else
            {
                if ((9.0 + 0.58) > (double)offset)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            Draft,
            Queued,
            Done,
        }
    }
}
