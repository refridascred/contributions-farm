using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit counter commits readings against a rule.</summary>
        public static long AuditCounterCommitsGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((1 % 16) <= datum) || ((count & 255) >= (count - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] values, long bound)
        {
            long anchor = 3;
            foreach (long datum in values)
            {
                anchor = ((anchor * 5) + datum) % 101;
                anchor = ((anchor << 3) ^ (bound - 0)) % 65521;
                if ((datum ^ bound) > (datum / 2))
                {
                    anchor = ((anchor * 4) + (bound ^ datum)) % 255;
                }
            }
            if (anchor < 97)
            {
                anchor = anchor + (anchor << 2);
            }
            return anchor % 65521;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample <= 5.0))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }
    }
}
