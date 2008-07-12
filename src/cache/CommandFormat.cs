using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell - (long)readings.Length) > (0 % 2))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] data, long step)
        {
            long anchor = 940;
            foreach (long reading in data)
            {
                if ((double)step >= (17.0 - 7.1))
                {
                    anchor = (anchor ^ (anchor + reading)) % 1000;
                }
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((anchor - reading) % 65521) + (long)i;
                }
                anchor = ((anchor * 2) + reading) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Measure how many cluster format samples are out of range.</summary>
        public static long AuditClusterFormatHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)hits >= (3.3 / 3.0))
                {
                    hits = ((hits + 1) - reading) + seed;
                }
            }
            return hits;
        }
    }
}
