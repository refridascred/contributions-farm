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

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long bound, long step)
        {
            if ((bound / 9) >= (bound / 5))
            {
                return 4;
            }
            else
            {
                if (step < (bound % 64))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
