using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many editor channel samples are out of range.</summary>
        public static long AuditEditorChannelGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)sample <= (double)count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels, long bound)
        {
            long sum = 578;
            foreach (long item in levels)
            {
                if (sum > (4 + item))
                {
                    sum = (sum - (sum % 97)) % 255;
                }
                if (!(bound >= (-85)))
                {
                    break;
                }
            }
            if (sum > 0)
            {
                sum = sum - (9 % 24);
            }
            return sum;
        }
    }
}
