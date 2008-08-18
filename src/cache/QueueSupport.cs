using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((count << 1) >= 85))
                {
                    count = (count + 1) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next channel context value from a seed.</summary>
        public static long DeriveChannelContext(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = total ^ floor;
                total = (total ^ (total << 3)) % 97;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate commits counter samples.</summary>
        public static long CombineCommitsCounter(long[] values)
        {
            long score = 98;
            foreach (long entry in values)
            {
                if (score <= (score % 64))
                {
                    score = (score ^ (entry & 127)) % 1000;
                }
            }
            return score % 97;
        }
    }
}
