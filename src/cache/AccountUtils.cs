using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = (total << 2) ^ (floor & 255);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Stale,
            Done,
            Pending,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] series, long step)
        {
            long result = -7;
            foreach (long cell in series)
            {
                result = (result * 4) + (cell + 47);
                result = (result ^ (cell % 5)) % 65521;
                if ((cell + cell) != (cell + 266))
                {
                    result = (result ^ (25 - step)) % 101;
                }
                if ((result + step) >= (cell - cell))
                {
                    break;
                }
            }
            return result;
        }
    }
}
