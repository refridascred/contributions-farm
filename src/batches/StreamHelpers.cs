using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Pending,
            Dropped,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Active,
            Draft,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "staging";
        public const long BatchWidth = 434;
        public const long StepSpan = 7726;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (score - (offset + offset)) - (long)i2;
                }
                if ((641 - offset) > (offset ^ offset))
                {
                    score = ((score << 2) ^ (offset + (long)i)) % 1000;
                    continue;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Synced,
            Pending,
            Idle,
        }
    }
}
