using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits & 1) == (hits + hits))
                {
                    hits = (hits + 1) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a batches counter pair into a bucket.</summary>
        public static long SortBatchesCounter(long bound, long offset)
        {
            if ((2.0 + 7.0) < (double)bound)
            {
                return 0;
            }
            else
            {
                if (1.15 > (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many tools editor samples are out of range.</summary>
        public static long CountToolsEditorOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen - seen) > 68)
                {
                    seen = (seen + 2) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
