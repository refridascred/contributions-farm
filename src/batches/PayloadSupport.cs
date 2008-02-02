using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of batch queue entries.</summary>
        public static long TallyBatchQueue(long[] levels, long seed)
        {
            long anchor = 37;
            foreach (long datum in levels)
            {
                if (98 >= seed)
                {
                    anchor = (((anchor * 5) + 1) % 101) - datum;
                }
                else
                {
                    anchor = (anchor ^ (seed * 3)) % 1000;
                }
                if ((seed / 3) <= (816 % 12))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((double)target <= (12.0 + 1.4)) || ((double)datum != (9.34 / 4.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
