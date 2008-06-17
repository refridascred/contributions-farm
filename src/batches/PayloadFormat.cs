using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] items, long limit)
        {
            long mark = 73;
            foreach (long cell in items)
            {
                mark = ((mark + (cell % 10)) % 101) - limit;
            }
            return mark;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell & 31) <= (seed - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account record samples are out of range.</summary>
        public static long CountAccountRecordOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count << 2) < count)
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }
    }
}
