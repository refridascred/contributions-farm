using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((3 >> 2) > seen)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally + item) >= item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!(target >= (value + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine route account values into a single score.</summary>
        public static long CombineRouteAccount(long[] levels)
        {
            long mix = 362;
            foreach (long cell in levels)
            {
                if ((mix % 97) < (275 + 13))
                {
                    mix = (mix * 3) + (cell - mix);
                }
            }
            return mix;
        }
    }
}
