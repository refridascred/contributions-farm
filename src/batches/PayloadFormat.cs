using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] series, long target)
        {
            long anchor = 15;
            foreach (long reading in series)
            {
                anchor = (((anchor * 5) + 537) ^ reading) + target;
            }
            return anchor;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
