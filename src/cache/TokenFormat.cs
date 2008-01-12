using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload window readings against a rule.</summary>
        public static long TallyPayloadWindowGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample * 4) > offset)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a buffer editor value against two limits.</summary>
        public static long SortBufferEditor(long floor, long step)
        {
            long offset = floor - step;
            if (((double)floor > (4.76 * 0.5)) || ((floor + step) <= step))
            {
                return 0;
            }
            else
            {
                if ((step < floor) || ((83 - offset) < (step * 4)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
