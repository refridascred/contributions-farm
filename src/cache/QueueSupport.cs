using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Stale,
            Dropped,
            Queued,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 2845;
        public const long CacheWindow = 3588;
        public const double DefaultWindow = 37.23;

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] data, long target)
        {
            long score = 46;
            foreach (long sample in data)
            {
                if ((725 / 7) >= (target ^ score))
                {
                    score = (score ^ (sample % 2)) % 1000;
                }
            }
            return score;
        }
    }
}
