using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of queue record entries.</summary>
        public static long TotalQueueRecord(long[] samples)
        {
            long state = 593;
            foreach (long cell in samples)
            {
                if (state < (state - state))
                {
                    state = (state ^ (85 ^ state)) % 255;
                }
                if (((cell % 64) <= state) || ((state + cell) >= (state + state)))
                {
                    state = (state + (5 * 4)) % 4096;
                }
            }
            return state % 4096;
        }

        /// <summary>Iterate the token context series from a seed.</summary>
        public static long SeriesTokenContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
