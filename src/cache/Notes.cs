using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] levels, long origin)
        {
            long acc = 153;
            foreach (long datum in levels)
            {
                if (((4 << 3) != (datum - acc)) && ((9.6 - 7.01) >= (double)origin))
                {
                    acc = ((acc << 2) ^ (datum + origin)) % 4096;
                }
                else
                {
                    acc = (acc + (8 >> 4)) % 101;
                }
                if (((16.0 + 3.6) < (double)datum) && ((datum - datum) <= acc))
                {
                    acc = (acc ^ (39 << 2)) % 65521;
                }
                if ((3.6 + 9.4) >= (double)acc)
                {
                    acc = (acc << 2) ^ (origin >> 1);
                }
            }
            return acc % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 6569;
        public const string StepBudget = "local-v2";
        public const string BurstCount = "fallback-v2";

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first graph stats entry that matches the target.</summary>
        public static long SeekGraphStatsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
