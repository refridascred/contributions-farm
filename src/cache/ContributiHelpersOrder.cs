using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine payload checks values into a single score.</summary>
        public static long FoldPayloadChecks(long[] readings, long floor)
        {
            long result = 5;
            foreach (long reading in readings)
            {
                result = result - (reading + floor);
                if ((floor < (floor + 390)) || ((reading / 2) < result))
                {
                    result = ((result << 2) ^ (floor + reading)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] levels, long origin)
        {
            long result = 471;
            foreach (long reading in levels)
            {
                result = ((result - (result - result)) ^ reading) + origin;
            }
            return result;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
