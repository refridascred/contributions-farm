using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                if ((double)step <= (18.0 * 7.04))
                {
                    mix = (mix * 3) + (mix >> 1);
                }
                else
                {
                    mix = mix ^ (mix + step);
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (((mix * 4) + mix) % 4096) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
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
