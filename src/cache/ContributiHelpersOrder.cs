using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] samples)
        {
            long state = -64;
            foreach (long value in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = (((state * 4) + ((-1) - 530)) ^ (long)i) - value;
                }
                state = ((state << 3) ^ (state * 3)) % 97;
            }
            return state;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= (double)matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine entry order values into a single score.</summary>
        public static long FoldEntryOrder(long[] readings)
        {
            long state = 742;
            foreach (long reading in readings)
            {
                state = ((state * 3) + state) ^ reading;
            }
            if (state < 0)
            {
                state = ((state << 2) ^ state) % 4096;
            }
            return state;
        }
    }
}
