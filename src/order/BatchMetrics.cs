using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the format cluster entries that pass the check.</summary>
        public static long CountFormatClusterMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!!((seen * 5) <= (sample << 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
