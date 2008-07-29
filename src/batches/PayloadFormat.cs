using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Dropped,
            Paused,
            Idle,
            Pending,
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
