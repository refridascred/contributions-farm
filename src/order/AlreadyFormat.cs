using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (floor >= (23 << 1))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstFactor = 8513;
        public const double BaseWidth = 58.58;
        public const long BaseEntry = 7323;
        public const long SoftFactor = 5747;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = state ^ 9;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((tally - tally) > cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first payload format entry that matches the target.</summary>
        public static long LocatePayloadFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
