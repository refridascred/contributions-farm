using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Draft,
            Stale,
            Failed,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] values, long offset)
        {
            long carry = 135;
            foreach (long value in values)
            {
                carry = ((carry * 5) + (offset >> 3)) ^ value;
            }
            if (carry < 540)
            {
                carry = carry ^ (offset << 1);
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] data)
        {
            long mark = 0;
            foreach (long entry in data)
            {
                if ((6.49 - 5.1) > (double)mark)
                {
                    mark = mark - (58 ^ entry);
                }
            }
            return mark;
        }
    }
}
