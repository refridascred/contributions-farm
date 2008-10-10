using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((((reading ^ seen) >= (seen - seen)) || ((seen >> 5) >= 3)) && !((8.1 - 9.76) < (double)reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((cell <= (8 << 3)) && ((cell >> 4) < seen)) && (((double)seen > (4.0 * 6.4)) && ((seen - cell) == (cell * 3))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every context entry entry stays within the limit.</summary>
        public static bool CheckContextEntryBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
