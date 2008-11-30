using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit queue cache readings against a rule.</summary>
        public static long TallyQueueCacheHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((26 * 3) < reading) || ((reading & 31) == (bound << 1)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Weight { get; set; }
            public bool Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseLevel = "primary-edge";
        public const long HardBuffer = 6762;
        public const string BatchBuffer = "staging-1";
        public const long LimitScore = 7050;
        public const double RetryBuffer = 56.34;
    }
}
