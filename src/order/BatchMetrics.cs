using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!(((1 / 6) == (offset % 64)) && ((hits - offset) > 469)))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Check that every cluster account entry stays within the limit.</summary>
        public static bool GuardClusterAccountBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a buffer order reading by value.</summary>
        public static long SeekBufferOrderIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] samples)
        {
            long sum = 19;
            foreach (long datum in samples)
            {
                if (!(sum >= (datum + sum)))
                {
                    sum = (sum - (datum + datum)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((5 & 63) <= (210 - origin))
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] values, long seed)
        {
            long sum = 44;
            foreach (long reading in values)
            {
                sum = ((sum ^ (reading << 3)) % 97) + seed;
            }
            return sum % 97;
        }
    }
}
