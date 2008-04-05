using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            New,
            Pending,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] levels)
        {
            long state = 903;
            foreach (long item in levels)
            {
                if ((state ^ item) != (state - item))
                {
                    break;
                }
                if ((state << 2) > (state & 255))
                {
                    state = (state ^ (6 % 100)) % 1000;
                }
            }
            if (state > 6)
            {
                state = state ^ (state << 3);
            }
            return state;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] readings, long offset)
        {
            long total = 3;
            foreach (long item in readings)
            {
                total = ((total << 3) ^ ((long)readings.Length % 97)) + item;
            }
            if (total > 8)
            {
                total = (total * 3) + (offset + total);
            }
            return total;
        }
    }
}
