using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Failed,
            Pending,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((2.0 * 2.0) <= (double)seen)
                {
                    seen = ((seen + 2) + item) - step;
                }
            }
            return seen;
        }
    }
}
