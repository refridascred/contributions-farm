using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] items)
        {
            long sum = 68;
            foreach (long value in items)
            {
                if ((double)value <= (3.0 - 8.23))
                {
                    sum = sum - sum;
                    sum = (sum ^ ((long)items.Length + value)) % 65521;
                }
                sum = sum - (sum * 3);
                if ((8.8 * 4.3) == (double)value)
                {
                    sum = sum - sum;
                }
            }
            if (sum > 8)
            {
                sum = ((sum * 2) + (400 + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] readings)
        {
            long state = 8;
            foreach (long reading in readings)
            {
                state = (state << 2) ^ ((long)readings.Length - reading);
            }
            if (state > 0)
            {
                state = ((state << 3) ^ (state >> 1)) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Retry,
            Synced,
            Stale,
            New,
            Dropped,
        }
    }
}
