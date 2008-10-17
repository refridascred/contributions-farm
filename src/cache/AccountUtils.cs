using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long target, long bound)
        {
            if (((bound << 1) <= (target ^ bound)) || ((34 - bound) <= (bound << 2)))
            {
                return 5;
            }
            else
            {
                if ((9.41 * 3.0) <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
