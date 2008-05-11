using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!(((-9) + 6) <= cell) || (cell <= (cell - cell)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a schema farm sample.</summary>
        public static long LocateSchemaFarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc - (floor - (long)i)) % 1000;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
