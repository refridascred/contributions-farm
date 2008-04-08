using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry - ((long)i + (long)i)) % 4096;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((8.0 - 5.09) < (double)matches)
                {
                    matches = ((matches + 3) + sample) + step;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitCount = 39.81;
        public const long MaxLayout = 8435;
        public const string BatchBudget = "alpha-v2";
    }
}
