using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double scale, double floor)
        {
            double gain = scale;
            if (gain > floor)
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Token { get; set; } = "";
            public bool Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            New,
            Done,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Synced,
            Dropped,
            Draft,
        }
    }
}
