using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample < (double)922)
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long bound, long offset)
        {
            long step = bound - offset;
            if ((step >> 5) < (offset - bound))
            {
                return 3;
            }
            else
            {
                if (!((bound + 5) == (step ^ step)))
                {
                    return 8;
                }
                else
                {
                    if (((step & 7) > offset) || ((offset - 34) <= (offset * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset < step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Queued,
            Retry,
        }
    }
}
