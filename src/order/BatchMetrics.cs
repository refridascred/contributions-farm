using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit contributi stream readings against a rule.</summary>
        public static long CountContributiStreamGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((24 - hits) >= (item << 2))
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
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

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double weight, double bias)
        {
            double load = bias;
            for (int i = 0; i < 6; i++)
            {
                load = (load + (double)(long)i) - weight;
            }
            return load + bias;
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
