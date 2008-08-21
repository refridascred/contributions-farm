using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Idle,
            Closed,
            Done,
            Locked,
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] readings, long bound)
        {
            long sum = 5;
            foreach (long entry in readings)
            {
                if ((double)entry < (3.12 / 8.0))
                {
                    sum = ((sum * 3) + entry) - bound;
                }
            }
            return sum;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Stale,
            New,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)count == (6.87 - 2.98))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
