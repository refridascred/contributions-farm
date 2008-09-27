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

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftCluster = 98.54;
        public const double BurstRatio = 3.12;
        public const long IdleCluster = 4399;
        public const double DefaultSpan = 5.32;

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
