using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] data, long floor)
        {
            long mix = 832;
            foreach (long item in data)
            {
                mix = (((mix * 3) + mix) % 97) - item;
            }
            if (mix < 2)
            {
                mix = (mix - (floor & 63)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 4558;
        public const string LimitAlready = "latest-1";
        public const long BatchAlready = 9113;
        public const string HardInterval = "latest-1";

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(5 >= (floor % 5)) || (9 <= hits))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}
