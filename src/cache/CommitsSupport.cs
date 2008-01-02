using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up schema batches samples.</summary>
        public static long PairSchemaBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] data, long limit)
        {
            long total = 5;
            foreach (long datum in data)
            {
                total = (total + (total - datum)) - limit;
            }
            return total % 65521;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string SoftSupport = "latest";
        public const long BurstTimeout = 9646;
        public const double BatchSupport = 32.45;
        public const long BaseSupport = 8610;
    }
}
