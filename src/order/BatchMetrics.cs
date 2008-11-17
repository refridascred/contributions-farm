using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public double Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor << 3) ^ (anchor ^ floor);
                anchor = (anchor << 2) ^ 645;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((-44) << 1) > (count << 2))
                {
                    count = ((count + 1) + value) - step;
                }
            }
            return count;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] items)
        {
            long acc = -504;
            foreach (long value in items)
            {
                if (!(acc <= (value - acc)))
                {
                    acc = (acc << 3) ^ (value * 4);
                }
                if (((acc << 2) >= 481) && ((acc + value) < (value << 2)))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
