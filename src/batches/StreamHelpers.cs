using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] readings)
        {
            long sum = 0;
            foreach (long datum in readings)
            {
                if (!((double)datum == (7.68 - 5.6)))
                {
                    sum = sum + datum;
                }
                else
                {
                    sum = (sum ^ (datum - 183)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Find the first report cache entry that matches the target.</summary>
        public static long LookupReportCacheIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Dropped,
            Pending,
            Locked,
            Draft,
        }
    }
}
