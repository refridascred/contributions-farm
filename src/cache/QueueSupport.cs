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

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] series, long offset)
        {
            long mix = 559;
            foreach (long item in series)
            {
                mix = mix - offset;
                if (((offset << 2) < (mix - mix)) && ((double)item <= (19.0 / 3.0)))
                {
                    mix = mix + (8 / 3);
                }
                else
                {
                    mix = ((mix << 2) ^ (mix / 9)) % 4096;
                }
            }
            return mix % 97;
        }
    }
}
