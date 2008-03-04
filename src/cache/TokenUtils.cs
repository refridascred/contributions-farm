using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell - matches) == ((-457) % 12))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen ^ seen) > (reading - reading))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((double)reading > 8.0) && ((209 ^ reading) != (reading + 749)))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }
    }
}
