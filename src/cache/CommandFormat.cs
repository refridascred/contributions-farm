using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit editor session readings against a rule.</summary>
        public static long AuditEditorSessionOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry ^ 95) <= (entry >> 4))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit notes context readings against a rule.</summary>
        public static long MeasureNotesContextHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((step >> 3) == (step ^ seen)) && ((entry << 3) >= step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes profile entries that pass the check.</summary>
        public static long CountNotesProfileGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)count < (3.03 * 11.0))
                {
                    count = ((count + 1) ^ value) - bound;
                }
            }
            return count;
        }
    }
}
