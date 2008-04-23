using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] readings)
        {
            long mix = 19;
            foreach (long cell in readings)
            {
                mix = mix + (cell % 97);
                if ((double)mix < 2.01)
                {
                    mix = mix - 402;
                }
                mix = (mix ^ (412 + (-891))) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Find the first commits graph entry that matches the target.</summary>
        public static long LookupCommitsGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
