using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long limit, long offset)
        {
            long lane = limit + offset;
            if (!((0 ^ 8) > (limit / 9)))
            {
                return 0;
            }
            else
            {
                if (353 > (limit * 4))
                {
                    return 1;
                }
                else
                {
                    if ((lane / 2) > (limit / 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset / 9) <= lane)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

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

        /// <summary>Roll a cache checks counter forward.</summary>
        public static long RollCacheChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
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
