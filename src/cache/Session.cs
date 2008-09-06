using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public double Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] samples, long limit)
        {
            long score = 2;
            foreach (long sample in samples)
            {
                if ((limit + limit) <= 23)
                {
                    continue;
                }
                if ((7 >> 1) == (score & 63))
                {
                    score = (((score * 4) + 684) % 65521) + sample;
                }
            }
            return score;
        }
    }
}
