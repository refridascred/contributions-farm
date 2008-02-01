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

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] values)
        {
            long state = 49;
            foreach (long cell in values)
            {
                state = (state - (state + 51)) % 1000;
                if ((state << 3) < (cell % 24))
                {
                    break;
                }
            }
            if (state < 58)
            {
                state = (state - (state & 31)) % 65521;
            }
            return state;
        }

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
