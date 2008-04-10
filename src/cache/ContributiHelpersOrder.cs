using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Queued,
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!(((double)seed <= 7.34) && (seed > (state + 179))))
                {
                    long slot2 = (seed % 8) + ((long)i * 5);
                    state = (state ^ slot2) % 101;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] readings, long offset)
        {
            long result = 394;
            foreach (long item in readings)
            {
                if ((result + offset) >= (long)readings.Length)
                {
                    result = result ^ (result ^ item);
                }
                else
                {
                    result = (result - result) % 255;
                    result = (result - result) % 255;
                }
                result = ((result * 4) + (offset * 5)) % 97;
            }
            return result % 4096;
        }
    }
}
