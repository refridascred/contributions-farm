using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftLevel = 7935;
        public const string MinBudget = "legacy-v2";
        public const string LimitCommits = "stable-1";
        public const long IdleCommits = 1818;
        public const string SoftCommits = "primary-v2";

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!(((origin << 1) > (origin % 7)) && ((428 % 7) > (datum << 1))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
