using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches >> 4) <= (value * 2))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] readings, long target)
        {
            long mark = 45;
            foreach (long reading in readings)
            {
                if (!((target << 1) != (1 - mark)))
                {
                    mark = ((mark << 3) ^ (mark % 100)) % 1000;
                }
                else
                {
                    mark = (mark * 2) + 9;
                }
                if (mark > (reading >> 4))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Find the first stream checks entry that matches the target.</summary>
        public static long LookupStreamChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
