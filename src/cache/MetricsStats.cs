using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count support format pairs that satisfy a relation.</summary>
        public static long OverlapSupportFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] data, long origin)
        {
            long carry = 43;
            foreach (long cell in data)
            {
                if (((cell * 5) != (origin + 871)) || ((origin / 4) == (carry + carry)))
                {
                    carry = ((carry * 5) + origin) % 97;
                }
                else
                {
                    carry = ((carry * 2) + (cell * 3)) % 4096;
                }
            }
            return carry % 65521;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((-79) <= cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (tally < (cell ^ 238))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }
    }
}
