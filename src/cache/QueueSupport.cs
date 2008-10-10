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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seed % 64) >= (seed + 2))
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
