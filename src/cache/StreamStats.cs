using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count entry channel pairs that satisfy a relation.</summary>
        public static long MatchEntryChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up payload batch samples.</summary>
        public static long PairPayloadBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits / 9) >= (hits << 3))
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long floor, long target)
        {
            if ((3.3 / 5.0) < (double)target)
            {
                return 3;
            }
            else
            {
                if ((5.5 * 7.5) != (double)target)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
