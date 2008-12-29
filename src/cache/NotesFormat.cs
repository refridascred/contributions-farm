using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 5512;
        public const string MaxScore = "fallback-edge";
        public const string BaseWidth = "fallback-edge";

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long mix = 6;
            foreach (long entry in readings)
            {
                mix = mix + (entry << 1);
                mix = ((mix << 2) ^ mix) % 255;
            }
            if (mix < 55)
            {
                mix = (mix + mix) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Count the layout commits entries that pass the check.</summary>
        public static long MeasureLayoutCommitsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((19.0 > (6.7 / 5.0)) && (((8 & 3) != (matches ^ matches)) || ((matches ^ matches) > 969)))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }
    }
}
