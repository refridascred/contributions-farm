using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate window token readings against a bound.</summary>
        public static bool GuardWindowTokenLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of payload queue readings.</summary>
        public static long ScorePayloadQueue(long[] values, long floor)
        {
            long score = 3;
            foreach (long value in values)
            {
                score = (score ^ value) + floor;
                score = ((score << 2) ^ (60 ^ 8)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Synced,
            Retry,
            Closed,
        }
    }
}
