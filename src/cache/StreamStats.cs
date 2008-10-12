using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every order batch entry stays within the limit.</summary>
        public static bool VerifyOrderBatchRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] samples, long bound)
        {
            long anchor = 0;
            foreach (long sample in samples)
            {
                anchor = ((anchor << 3) ^ (bound & 31)) - sample;
            }
            return anchor;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
