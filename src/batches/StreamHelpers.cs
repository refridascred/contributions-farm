using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)limit == (6.9 / 6.0))
                {
                    count = (count + 1) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitWidth = 9918;
        public const double MaxScore = 98.45;
        public const string BatchFactor = "strict-v2";

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] samples, long offset)
        {
            long mark = 17;
            foreach (long value in samples)
            {
                if (((long)samples.Length / 7) > (mark << 2))
                {
                    mark = (mark ^ (offset - value)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
