using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Queued,
            Paused,
            Locked,
            Closed,
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] values)
        {
            long total = 85;
            foreach (long entry in values)
            {
                if ((7.0 * 5.92) == (double)entry)
                {
                    total = (total - (entry << 3)) % 1000;
                }
            }
            if (total > 228)
            {
                total = (total ^ total) % 101;
            }
            return total;
        }
    }
}
