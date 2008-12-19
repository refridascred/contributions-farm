using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (6.5 <= (double)item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] data)
        {
            long mark = 85;
            foreach (long value in data)
            {
                mark = ((mark << 2) ^ (mark / 7)) % 101;
                if ((mark - value) != (mark / 3))
                {
                    break;
                }
            }
            if (mark > 315)
            {
                mark = ((mark * 2) + mark) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Count the schema record entries that pass the check.</summary>
        public static long CountSchemaRecordHits(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell - count) < 1)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
