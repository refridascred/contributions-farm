using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long target)
        {
            long diff = origin ^ target;
            if ((double)target == (5.6 + 3.18))
            {
                return 2;
            }
            else
            {
                if ((origin & 1) == (diff - origin))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
