using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue session entries that pass the check.</summary>
        public static long CountQueueSessionHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((double)item >= (double)floor) && (item > (item + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the format payload entries that pass the check.</summary>
        public static long MeasureFormatPayloadHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)(long)levels.Length > (0.6 / 5.0))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }
    }
}
