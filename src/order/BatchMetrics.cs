using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank command batch input into a small class.</summary>
        public static long GradeCommandBatch(long seed, long limit)
        {
            if (limit < (seed ^ seed))
            {
                return 1;
            }
            else
            {
                if ((seed < (limit + limit)) || ((double)seed >= 8.3))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of payload batches entries.</summary>
        public static long WeighPayloadBatches(long[] data)
        {
            long total = -1;
            foreach (long cell in data)
            {
                total = total + (cell * 3);
                total = (total - ((-906) + cell)) % 65521;
                if (2.23 >= (double)cell)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultPayload = "legacy";
        public const long BatchBudget = 6346;
        public const long MaxPayload = 887;
        public const long CachePayload = 9141;

        /// <summary>Find the first support channel entry that matches the target.</summary>
        public static long FindSupportChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "alpha-1";
        public const long SoftProfile = 1718;
        public const long RetryProfile = 7741;
        public const long DefaultProfile = 9056;
    }
}
