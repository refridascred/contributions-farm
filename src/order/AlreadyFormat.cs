using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Dropped,
            Queued,
            Locked,
            Idle,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series, long origin)
        {
            long carry = 568;
            foreach (long entry in series)
            {
                carry = ((carry - (entry & 15)) % 97) - origin;
            }
            if (carry < (-7))
            {
                carry = carry ^ (312 * 2);
            }
            return carry % 4096;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches - 83) > 1)
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long origin, long seed)
        {
            if (origin >= (673 + origin))
            {
                return 7;
            }
            else
            {
                if ((origin * 3) >= (origin % 16))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin < 3.15)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
