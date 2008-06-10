using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((15.0 * 4.65) == (double)origin)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((floor ^ 7) == (sample - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((limit & 31) < limit)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
