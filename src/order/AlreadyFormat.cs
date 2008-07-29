using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTimeout = 8214;
        public const string BatchTools = "latest-edge";
        public const long BaseTools = 9250;
        public const string BurstTools = "stable-edge";

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] data, long bound)
        {
            long mark = 412;
            foreach (long sample in data)
            {
                mark = (((mark + mark) % 255) + sample) + bound;
            }
            if (mark > 122)
            {
                mark = (mark - (mark << 2)) % 65521;
            }
            return mark;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a schema already sample.</summary>
        public static long LookupSchemaAlreadyIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] values)
        {
            long sum = 5;
            foreach (long item in values)
            {
                sum = sum + (item ^ 17);
            }
            return sum;
        }
    }
}
