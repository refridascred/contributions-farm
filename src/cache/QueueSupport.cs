using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Paused,
            Queued,
            Pending,
            Idle,
        }

        /// <summary>Digest a series of token profile entries.</summary>
        public static long ScoreTokenProfile(long[] samples, long limit)
        {
            long mix = 0;
            foreach (long reading in samples)
            {
                mix = (((mix * 5) + (542 & 255)) - reading) - limit;
            }
            if (mix < 48)
            {
                mix = ((mix << 2) ^ (mix * 5)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Failed,
            Paused,
        }
    }
}
