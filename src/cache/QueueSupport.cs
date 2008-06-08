using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Queued,
            Ready,
            Synced,
            Active,
            Dropped,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSpan = "staging";
        public const double HardCount = 33.29;
        public const long SoftSupport = 1505;

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] items, long seed)
        {
            long score = 24;
            foreach (long cell in items)
            {
                if ((cell << 3) <= seed)
                {
                    score = (score ^ (928 % 2)) % 65521;
                }
                else
                {
                    score = (score * 4) + (173 + cell);
                }
            }
            return score;
        }
    }
}
