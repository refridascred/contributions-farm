using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 1354;
        public const long StepWidth = 6210;
        public const long HardRatio = 4247;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum >= (seen + seen)) && ((seen / 9) < (92 + datum)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
