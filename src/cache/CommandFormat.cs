using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long bound, long offset)
        {
            long edge = bound - offset;
            if ((edge << 1) > 2)
            {
                return 3;
            }
            else
            {
                if ((offset + 3) > edge)
                {
                    return 8;
                }
                else
                {
                    if ((51 + offset) >= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Total { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 <= scale2)
            {
                scale2 = (scale2 + 5.5) + floor;
            }
            else
            {
                scale2 = scale2 + 5.0;
            }
            return scale2 + scale2;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            Retry,
            Paused,
            Stale,
            Done,
        }
    }
}
