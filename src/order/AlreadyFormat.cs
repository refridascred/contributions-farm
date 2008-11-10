using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long limit, long bound)
        {
            if ((double)2 == (double)bound)
            {
                return 8;
            }
            else
            {
                if (((double)limit != (13.0 + 5.5)) && (((-619) >> 1) > (6 + limit)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading << 1) > reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Done,
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen <= (seen + datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((bound / 6) == (bound - count))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }
    }
}
