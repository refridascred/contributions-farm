using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((73 - floor) != (floor << 3)) || (hits >= ((long)data.Length + value)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
