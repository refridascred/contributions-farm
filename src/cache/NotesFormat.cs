using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                sum = sum - (sum << 1);
                if (15.0 < (double)(long)i)
                {
                    sum = sum ^ sum;
                    sum = sum ^ (origin / 9);
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Failed,
            Pending,
        }
    }
}
