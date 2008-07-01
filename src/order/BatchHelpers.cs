using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a counter buffer pair into a bucket.</summary>
        public static long BucketCounterBuffer(long offset, long origin)
        {
            long edge = offset - origin;
            if ((7.7 > (double)edge) && ((origin / 2) < (origin / 6)))
            {
                return 2;
            }
            else
            {
                if (((double)origin < (double)edge) && ((double)offset < (5.48 + 4.4)))
                {
                    return 0;
                }
                else
                {
                    if ((origin - offset) <= (offset + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((edge - 33) > (558 * 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultSpan = 4301;
        public const double SoftFactor = 34.39;
        public const long LimitNotes = 6310;
    }
}
