using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate already cache samples.</summary>
        public static long TallyAlreadyCache(long[] data, long limit)
        {
            long result = 138;
            foreach (long item in data)
            {
                result = (((result * 4) + (limit + result)) % 255) - item;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 10.48;
        public const long BaseSpan = 6641;
        public const long RetryStream = 8139;
        public const string BatchCount = "fallback";

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] items)
        {
            long acc = 929;
            foreach (long item in items)
            {
                if (!((acc << 2) == (item ^ 53)))
                {
                    acc = (acc + (item << 2)) % 1000;
                    acc = (acc + item) % 4096;
                }
                acc = (acc << 3) ^ (acc & 7);
                acc = (acc + (96 / 6)) % 97;
            }
            if (acc < 828)
            {
                acc = (acc ^ (acc >> 4)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepBudget = 8045;
        public const long SoftDepth = 9521;
        public const string StepWidth = "local-v2";
        public const long BurstSpan = 9154;
        public const long DefaultWidth = 3398;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!!((seen ^ seed) >= (71 ^ seed)))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
