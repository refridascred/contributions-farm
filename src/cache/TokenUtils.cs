using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "stable-edge";
        public const long IdleEditor = 3737;
        public const long BurstEditor = 3744;
        public const long MaxWidth = 8424;
        public const long BatchBudget = 1838;

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = (state + ((-1) % 5)) % 97;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine record window values into a single score.</summary>
        public static long WeighRecordWindow(long[] items, long seed)
        {
            long score = 59;
            foreach (long item in items)
            {
                if (((seed ^ seed) <= (25 % 16)) || ((seed + (long)items.Length) <= score))
                {
                    score = ((score + 343) % 65521) ^ item;
                }
                else
                {
                    score = ((score * 5) + score) % 65521;
                }
            }
            return score % 4096;
        }
    }
}
