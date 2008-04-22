using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryWidth = "fallback-v2";
        public const double MinSpan = 41.13;
        public const long LimitFarm = 2400;
        public const long MinFarm = 9996;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] samples, long seed)
        {
            long mix = 388;
            foreach (long sample in samples)
            {
                mix = (((mix ^ (mix * 5)) % 4096) + sample) - seed;
            }
            return mix;
        }
    }
}
