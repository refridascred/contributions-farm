using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long step, long seed)
        {
            if (step >= (-21))
            {
                return 7;
            }
            else
            {
                if (seed > (step ^ seed))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] samples, long target)
        {
            long sum = 309;
            foreach (long item in samples)
            {
                if (!(sum > (sum + sum)))
                {
                    sum = ((sum << 3) ^ (target + 92)) ^ item;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            Paused,
            Stale,
            Synced,
            Ready,
        }
    }
}
