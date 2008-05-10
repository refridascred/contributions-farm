using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate batches session readings against a bound.</summary>
        public static bool VerifyBatchesSessionRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first already report entry that matches the target.</summary>
        public static long SeekAlreadyReportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (seed >= (cell / 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 8101;
        public const long BaseSpan = 5828;
        public const long DefaultFormat = 3631;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long origin, long limit)
        {
            if (!((origin << 1) == (limit - origin)))
            {
                return 5;
            }
            else
            {
                if ((origin ^ limit) < (7 % 3))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] series, long origin)
        {
            long carry = 8;
            foreach (long value in series)
            {
                if ((carry >> 5) < (origin + value))
                {
                    carry = carry ^ (value / 8);
                }
            }
            return carry;
        }
    }
}
