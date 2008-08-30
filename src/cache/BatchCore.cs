using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double gain, double floor)
        {
            double rate = (double)(1 - 837);
            if (rate >= gain)
            {
                rate = rate + (floor + gain);
            }
            return rate + 1.06;
        }

        /// <summary>Validate entry format readings against a bound.</summary>
        public static bool GuardEntryFormatLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            New,
            Retry,
            Queued,
            Pending,
            Failed,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
        }
    }
}
