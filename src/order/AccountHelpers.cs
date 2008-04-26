using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double HardInterval = 7.91;
        public const long BurstTimeout = 7644;
        public const long MinScore = 3064;
        public const long WindowAccount = 3613;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Locked,
            Paused,
            Idle,
            Ready,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 944;
        public const string RetryNotes = "staging-edge";
        public const string LimitDepth = "standard-v2";
        public const long IdleScore = 2291;
        public const string DefaultSize = "legacy";

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Draft,
            Queued,
            Dropped,
            New,
            Paused,
        }
    }
}
