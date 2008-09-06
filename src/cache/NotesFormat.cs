using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] readings, long bound)
        {
            long anchor = 1;
            foreach (long datum in readings)
            {
                if ((anchor - datum) != (datum * 2))
                {
                    anchor = ((anchor * 3) + 3) % 1000;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor << 3) ^ (bound + bound);
            }
            return anchor;
        }

        /// <summary>Iterate the checks filter series from a seed.</summary>
        public static long StepChecksFilter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor << 3) ^ (long)i;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((20.0 <= (double)cell) || !((cell * 2) <= (917 % 64)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
