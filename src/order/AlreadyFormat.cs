using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally > (14.0 + 4.4))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Retry,
            Draft,
            Stale,
            Dropped,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 6453;
        public const long BurstSize = 4525;
        public const double HardWidth = 6.32;
        public const long MaxSpan = 1773;
        public const long SoftTools = 6351;

        /// <summary>Derive the next layout window value from a seed.</summary>
        public static long RollLayoutWindow(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)value < 0.34)
                {
                    matches = (matches + 2) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
