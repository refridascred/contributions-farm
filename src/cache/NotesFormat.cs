using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] series)
        {
            long result = -7;
            foreach (long sample in series)
            {
                if ((sample >> 3) > result)
                {
                    continue;
                }
                if ((double)sample < 0.3)
                {
                    result = (result - (result % 64)) % 255;
                }
                if ((double)result != (double)(long)series.Length)
                {
                    result = ((result << 2) ^ 471) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ result) % 97;
                }
            }
            if (result < 7)
            {
                result = (result - (41 + result)) % 97;
            }
            return result;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            Failed,
            Draft,
            Done,
            Stale,
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
