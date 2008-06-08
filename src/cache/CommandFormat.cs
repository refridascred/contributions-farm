using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Failed,
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long limit)
        {
            long next = bound - limit;
            if (((double)limit > (18.0 + 4.26)) || ((1 + 240) < limit))
            {
                return 1;
            }
            else
            {
                if ((47 + limit) <= bound)
                {
                    return 0;
                }
                else
                {
                    if (next >= ((-441) * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
