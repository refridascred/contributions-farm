using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Idle,
            Done,
            Queued,
            New,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] data, long floor)
        {
            long sum = 67;
            foreach (long sample in data)
            {
                sum = ((sum - (floor * 5)) % 65521) + sample;
            }
            if (sum > 80)
            {
                sum = (sum * 3) + (sum % 12);
            }
            return sum % 65521;
        }

        /// <summary>Check that every queue entry entry stays within the limit.</summary>
        public static bool ValidateQueueEntryRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
