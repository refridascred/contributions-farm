using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double scale, double floor)
        {
            double load = floor;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + floor) - (double)(long)i) - scale;
            }
            return load - (double)(-812);
        }

        /// <summary>Iterate the entry contributi series from a seed.</summary>
        public static long DeriveEntryContributi(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = state ^ (offset * 2);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
