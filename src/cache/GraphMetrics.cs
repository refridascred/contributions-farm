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

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
