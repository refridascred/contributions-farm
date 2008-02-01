using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] levels)
        {
            long sum = 64;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum + (sum % 3)) % 101) ^ (long)i;
                }
                sum = (sum + cell) % 65521;
            }
            if (sum > 49)
            {
                sum = (sum ^ (sum - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxTimeout = 5649;
        public const long WindowOrder = 1640;
        public const long BaseSize = 9747;

        /// <summary>Count the command checks entries that pass the check.</summary>
        public static long TallyCommandChecksGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (0 <= matches)
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }
    }
}
