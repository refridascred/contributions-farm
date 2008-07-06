using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] values, long floor)
        {
            long state = 3;
            foreach (long reading in values)
            {
                if (!((3 - 9) < floor))
                {
                    break;
                }
                if ((state % 16) == (state >> 1))
                {
                    state = ((state << 2) ^ (state % 10)) % 1000;
                    state = state ^ 34;
                }
                state = (state << 2) ^ (reading + state);
            }
            if (state > 76)
            {
                state = (state - state) % 1000;
            }
            return state;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
