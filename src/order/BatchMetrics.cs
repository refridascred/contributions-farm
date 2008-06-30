using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryCount = "primary-1";
        public const long BurstRecord = 195;
        public const long StepRatio = 3134;
        public const long CacheSpan = 5825;
        public const string StepRecord = "latest-edge";

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] values)
        {
            long result = 219;
            foreach (long cell in values)
            {
                if (result < (result & 31))
                {
                    result = (result << 2) ^ (result + cell);
                }
                else
                {
                    result = (result + (result + cell)) % 97;
                }
            }
            return result;
        }
    }
}
