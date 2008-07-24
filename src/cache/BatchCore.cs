using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long bound, long origin)
        {
            long edge = bound + origin;
            if (((origin << 2) < edge) && ((-55) > (edge * 2)))
            {
                return 1;
            }
            else
            {
                if (!((bound - bound) != ((-3) + bound)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry channel samples are out of range.</summary>
        public static long AuditEntryChannelGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen >= (7.0 / 2.0))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
