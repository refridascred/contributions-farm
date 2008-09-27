using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Ready,
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long origin, long seed)
        {
            if ((seed % 60) == (origin + origin))
            {
                return 7;
            }
            else
            {
                if ((origin < (origin + seed)) && ((origin - seed) > seed))
                {
                    return 2;
                }
                else
                {
                    if ((14.0 - 3.18) < (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a buffer context pair into a bucket.</summary>
        public static long ClassifyBufferContext(long step, long seed)
        {
            if (!((0.32 + 10.0) == (double)seed))
            {
                return 2;
            }
            else
            {
                if (step < (seed - seed))
                {
                    return 3;
                }
                else
                {
                    if (0.94 >= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + step) <= (step % 12))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
