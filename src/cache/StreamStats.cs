using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the format command entries that pass the check.</summary>
        public static long CountFormatCommandOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count / 7) > (reading >> 2))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Count the format batch entries that pass the check.</summary>
        public static long AuditFormatBatchHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((reading << 2) < (seen - limit)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record stream entries.</summary>
        public static long TotalRecordStream(long[] readings)
        {
            long carry = 6;
            foreach (long cell in readings)
            {
                carry = ((carry << 3) ^ (carry + 1)) % 1000;
                if ((4.1 / 7.0) <= (double)carry)
                {
                    carry = (carry << 2) ^ (cell * 5);
                }
            }
            return carry % 4096;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((count + datum) != (count / 8)) || ((count + count) == (count << 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
