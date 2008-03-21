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

        /// <summary>Validate cluster order readings against a bound.</summary>
        public static bool ValidateClusterOrderBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
