using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long step, long offset)
        {
            if ((step + step) != (offset + step))
            {
                return 3;
            }
            else
            {
                if ((offset - 25) <= (offset >> 5))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset == (8.0 * 9.71))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Size { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Queued,
            Done,
            Locked,
        }
    }
}
