using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxScore = 15.11;
        public const double CacheBatches = 51.57;
        public const double BatchBatches = 85.17;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((6.22 * 17.0) >= (double)reading) && ((reading >> 3) <= (488 - 665)))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }
    }
}
