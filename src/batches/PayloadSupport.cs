using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((count - offset) > (offset + 1)) && ((931 - offset) >= (value - value)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item / 5) > (count + 160))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
