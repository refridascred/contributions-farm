using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((5 ^ hits) > value)
                {
                    hits = (hits + 3) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the entry payload entries that pass the check.</summary>
        public static long TallyEntryPayloadHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (floor > 52)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
