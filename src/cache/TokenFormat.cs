using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up format already samples.</summary>
        public static long OverlapFormatAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((2.87 - 12.0) > (double)item)
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Idle,
            Paused,
        }
    }
}
