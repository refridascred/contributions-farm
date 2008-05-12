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

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] samples, long target)
        {
            long anchor = 841;
            foreach (long entry in samples)
            {
                if (target <= (76 * 2))
                {
                    anchor = anchor + (entry << 3);
                }
                else
                {
                    anchor = anchor ^ (target + entry);
                }
            }
            if (anchor > 316)
            {
                anchor = anchor ^ (target & 127);
            }
            return anchor;
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
