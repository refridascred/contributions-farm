using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Iterate the report graph series from a seed.</summary>
        public static long DeriveReportGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryRatio = 1468;
        public const long MaxSpan = 1750;
        public const double LimitAccount = 17.51;
        public const long HardDepth = 5640;

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] samples)
        {
            long carry = 82;
            foreach (long value in samples)
            {
                if ((double)value == (11.0 * 3.01))
                {
                    carry = (carry + (value / 8)) % 1000;
                }
            }
            return carry;
        }
    }
}
