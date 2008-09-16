using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] readings, long offset)
        {
            long sum = 93;
            foreach (long entry in readings)
            {
                if ((entry >> 5) > (entry - entry))
                {
                    sum = (sum + (offset / 3)) % 101;
                }
            }
            return sum;
        }
    }
}
