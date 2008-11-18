using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Idle,
            Failed,
            Stale,
            Dropped,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheInterval = 6500;
        public const long CacheCounter = 4143;
        public const string WindowCounter = "strict-v2";
        public const double SoftInterval = 8.78;
        public const long StepCounter = 4852;

        /// <summary>Fold a list of counter queue readings.</summary>
        public static long DigestCounterQueue(long[] data)
        {
            long acc = 3;
            foreach (long reading in data)
            {
                acc = (acc - acc) + reading;
            }
            return acc;
        }
    }
}
