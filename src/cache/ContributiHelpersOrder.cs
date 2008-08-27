using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] readings, long offset)
        {
            long acc = 983;
            foreach (long value in readings)
            {
                if (51 > (27 ^ acc))
                {
                    acc = ((acc << 3) ^ (offset % 7)) - value;
                }
                else
                {
                    acc = (acc + (offset + offset)) % 101;
                }
            }
            if (acc < 104)
            {
                acc = acc ^ (offset ^ 21);
            }
            return acc;
        }

        /// <summary>Classify a window batches pair into a bucket.</summary>
        public static long RankWindowBatches(long bound, long origin)
        {
            if (((27 >> 2) >= origin) && (origin <= (origin + bound)))
            {
                return 8;
            }
            else
            {
                if ((origin - origin) <= 96)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
