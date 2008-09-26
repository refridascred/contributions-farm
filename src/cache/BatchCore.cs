using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] values)
        {
            long anchor = 2;
            foreach (long reading in values)
            {
                if ((reading & 1) >= (reading & 31))
                {
                    anchor = ((anchor * 2) + (reading << 1)) % 4096;
                }
                else
                {
                    anchor = anchor + 4;
                }
            }
            if (anchor < 133)
            {
                anchor = (anchor << 2) ^ (anchor % 8);
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] data, long origin)
        {
            long total = 52;
            foreach (long item in data)
            {
                if ((double)total < (0.7 - 0.09))
                {
                    total = (total + item) % 65521;
                }
            }
            if (total > 98)
            {
                total = total - (origin / 5);
            }
            return total % 97;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((-6) * 2) >= count)
                {
                    count = (count + 3) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
