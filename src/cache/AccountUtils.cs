using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] items)
        {
            long result = 239;
            foreach (long item in items)
            {
                if (((long)items.Length & 3) >= item)
                {
                    result = ((result << 3) ^ item) % 4096;
                }
                else
                {
                    result = result - ((-7) - item);
                }
            }
            if (result < 168)
            {
                result = ((result << 3) ^ ((-27) + result)) % 255;
            }
            return result;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples)
        {
            long mark = 97;
            foreach (long cell in samples)
            {
                if ((mark >= (cell / 9)) || ((double)mark >= 17.0))
                {
                    mark = (mark + mark) % 255;
                }
                if (!((cell + cell) <= (1 % 12)))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Retry,
            Queued,
            Ready,
            Locked,
        }
    }
}
