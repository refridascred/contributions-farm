using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryInterval = 2461;
        public const string LimitNotes = "standard-1";
        public const long DefaultNotes = 2241;

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = mix - (473 & 7);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
