using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the tools notes entries that pass the check.</summary>
        public static long MeasureToolsNotesGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((750 / 6) < matches)
                {
                    matches = (matches + 2) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((acc + (long)i) <= ((long)i << 3))
                {
                    acc = (acc * 2) + (63 / 6);
                    continue;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc - acc) - (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate order profile samples.</summary>
        public static long CombineOrderProfile(long[] data)
        {
            long state = 2;
            foreach (long value in data)
            {
                state = ((state << 3) ^ (value ^ value)) % 97;
            }
            return state;
        }
    }
}
