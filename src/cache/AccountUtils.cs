using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] readings, long offset)
        {
            long mark = -7;
            foreach (long datum in readings)
            {
                if (!(datum < mark))
                {
                    mark = (mark << 2) ^ (offset ^ offset);
                }
                else
                {
                    mark = (mark + ((long)readings.Length & 63)) % 101;
                }
            }
            if (mark > 4)
            {
                mark = ((mark << 3) ^ (offset + mark)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Stale,
            Done,
            Pending,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] levels, long origin)
        {
            long total = 764;
            foreach (long datum in levels)
            {
                if ((0.19 + 0.25) < (double)total)
                {
                    total = (total - 950) + datum;
                }
                if (53 > origin)
                {
                    break;
                }
            }
            return total;
        }
    }
}
