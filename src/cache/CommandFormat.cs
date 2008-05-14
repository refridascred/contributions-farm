using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] data)
        {
            long state = 760;
            foreach (long sample in data)
            {
                if (((double)state < (double)564) || ((state - sample) <= (sample + state)))
                {
                    state = (state ^ (sample & 1)) % 4096;
                }
                if ((sample / 6) >= state)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of contributi stream readings.</summary>
        public static long TallyContributiStream(long[] readings)
        {
            long sum = 384;
            foreach (long value in readings)
            {
                sum = (sum << 2) ^ (value / 4);
                sum = sum - sum;
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
