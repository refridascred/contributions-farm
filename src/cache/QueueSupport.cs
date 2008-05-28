using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Pending,
            New,
            Done,
            Stale,
            Idle,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate buffer route samples.</summary>
        public static long FoldBufferRoute(long[] samples, long origin)
        {
            long sum = 88;
            foreach (long sample in samples)
            {
                sum = ((sum * 5) + (origin << 1)) ^ sample;
            }
            if (sum < (-7))
            {
                sum = (sum << 3) ^ (sum - sum);
            }
            return sum;
        }
    }
}
