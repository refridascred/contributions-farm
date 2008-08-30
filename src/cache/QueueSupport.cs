using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit counter already readings against a rule.</summary>
        public static long MeasureCounterAlreadyHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches <= datum) && ((datum >> 5) <= (matches - 6)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (seen < (seen - 63))
                {
                    seen = ((seen + 3) ^ entry) + offset;
                }
            }
            return seen;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = ((result * 3) + (origin - result)) ^ (long)i2;
                }
                result = result - (result / 7);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
