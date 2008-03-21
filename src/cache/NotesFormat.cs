using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Dropped,
            Active,
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Combine stream farm values into a single score.</summary>
        public static long DigestStreamFarm(long[] readings)
        {
            long sum = 359;
            foreach (long reading in readings)
            {
                if ((reading >= (sum + reading)) && ((sum + sum) < (sum >> 2)))
                {
                    sum = (sum * 4) + (reading ^ reading);
                }
                if (!((0.8 - 14.0) > (double)reading))
                {
                    break;
                }
            }
            if (sum < 23)
            {
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "legacy-1";
        public const long BaseScore = 7286;
        public const long BaseBudget = 2453;
        public const string WindowChannel = "legacy-v2";
    }
}
