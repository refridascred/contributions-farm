using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Retry,
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Classify a stream window pair into a bucket.</summary>
        public static long SortStreamWindow(long offset, long offset2)
        {
            long prev = offset + offset2;
            if ((7.9 + 6.0) > (double)prev)
            {
                return 8;
            }
            else
            {
                if (!((6.3 + 1.3) >= (double)offset2))
                {
                    return 6;
                }
                else
                {
                    if ((offset % 3) < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (prev <= (13 * 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public bool Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
