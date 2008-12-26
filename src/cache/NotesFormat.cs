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

        /// <summary>Audit report cluster readings against a rule.</summary>
        public static long CountReportClusterMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((65 - (long)levels.Length) > target) || ((target - matches) < (target & 15)))
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

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
