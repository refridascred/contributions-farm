using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Retry,
            Pending,
            Ready,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Draft,
            Synced,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long limit, long bound)
        {
            long step = limit - bound;
            if ((bound >> 2) <= (bound ^ bound))
            {
                return 3;
            }
            else
            {
                if ((step % 24) == (limit * 3))
                {
                    return 0;
                }
                else
                {
                    if ((bound - bound) < (limit / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
