using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                if (!((long)i >= anchor))
                {
                    long next = anchor;
                    anchor = (anchor * 5) + next;
                }
                anchor = anchor - ((long)i * 3);
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((0 - hits) <= hits)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }
    }
}
