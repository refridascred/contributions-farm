using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstScore = 7114;
        public const string BurstNotes = "primary-v2";
        public const long MaxNotes = 1743;
        public const long CacheBudget = 3180;
        public const long StepNotes = 4521;

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
