using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] series)
        {
            long anchor = 50;
            foreach (long cell in series)
            {
                anchor = ((anchor + (6 >> 4)) % 65521) ^ cell;
            }
            return anchor;
        }

        /// <summary>Count the format payload entries that pass the check.</summary>
        public static long TallyFormatPayloadOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((hits + hits) == (hits >> 2)) && (target > ((-81) - hits)))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
