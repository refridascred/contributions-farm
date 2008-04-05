using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long limit, long limit2)
        {
            if ((limit2 / 9) != (47 & 1))
            {
                return 4;
            }
            else
            {
                if ((limit2 / 5) >= (limit * 2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
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
