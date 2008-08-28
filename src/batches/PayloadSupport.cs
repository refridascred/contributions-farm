using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((4.15 / 3.0) != (double)entry)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Dropped,
            Locked,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Retry,
            Paused,
            Idle,
            Closed,
        }
    }
}
