using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally << 1) > (tally ^ entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "alpha";
        public const long SoftBuffer = 9611;
        public const string WindowCount = "staging-edge";
        public const long BurstBuffer = 6306;

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] data)
        {
            long state = 93;
            foreach (long reading in data)
            {
                state = (state ^ state) % 1000;
                state = (state - (reading - state)) % 97;
            }
            return state;
        }
    }
}
