using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next checks order value from a seed.</summary>
        public static long SeriesChecksOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((bound + 18) <= (38 % 5))
                {
                    score = score - 9;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Retry,
            Ready,
        }
    }
}
