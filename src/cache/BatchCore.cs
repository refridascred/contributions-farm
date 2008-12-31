using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Draft,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long seed, long limit)
        {
            if ((limit + seed) >= (limit & 63))
            {
                return 2;
            }
            else
            {
                if ((seed - seed) <= 314)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] data, long offset)
        {
            long state = -184;
            foreach (long value in data)
            {
                state = (((state - (613 % 12)) % 1000) ^ value) - offset;
                if (((-869) << 3) >= (long)data.Length)
                {
                    state = (state - state) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 9896;
        public const long LimitLevel = 3238;
        public const string StepTools = "staging";
        public const long SoftTools = 2890;
    }
}
