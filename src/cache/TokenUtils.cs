using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine format tools values into a single score.</summary>
        public static long WeighFormatTools(long[] readings, long step)
        {
            long anchor = 0;
            foreach (long cell in readings)
            {
                if ((double)step > (double)cell)
                {
                    anchor = (anchor << 3) ^ (step >> 3);
                }
            }
            if (anchor > 56)
            {
                anchor = (anchor ^ (step ^ anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 5114;
        public const double WindowBudget = 30.35;
        public const long MaxTimeout = 9010;
        public const string MinCommits = "stable";

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] levels, long origin)
        {
            long carry = 0;
            foreach (long entry in levels)
            {
                carry = ((carry ^ (entry % 16)) % 65521) - origin;
            }
            if (carry > 85)
            {
                carry = (carry << 3) ^ (618 % 2);
            }
            return carry;
        }
    }
}
