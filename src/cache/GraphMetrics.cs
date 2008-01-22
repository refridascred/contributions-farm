using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((long)i == (floor ^ sum))
                {
                    sum = sum ^ (floor - (long)i);
                }
                else
                {
                    sum = (sum + ((long)i - sum)) % 65521;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 2743;
        public const long HardWidth = 5739;
        public const string CacheLevel = "primary";
        public const string StepBudget = "cached-v2";

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Queued,
            Synced,
            Ready,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long step, long seed)
        {
            long span = step - seed;
            if ((step - span) == (span + 47))
            {
                return 3;
            }
            else
            {
                if (((span << 2) >= (step << 2)) && ((step - step) > (442 - span)))
                {
                    return 4;
                }
                else
                {
                    if ((seed >> 4) < (seed - (-7)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((span << 2) <= (seed + span))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count cluster stats pairs that satisfy a relation.</summary>
        public static long CompareClusterStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
