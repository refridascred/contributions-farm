using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen >> 5) > (target - item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values, long offset)
        {
            long sum = 93;
            foreach (long value in values)
            {
                if ((value + value) != (8 - offset))
                {
                    sum = (sum + (12 + offset)) % 255;
                }
                else
                {
                    sum = sum - offset;
                }
            }
            if (sum < 8)
            {
                sum = sum ^ sum;
            }
            return sum % 4096;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            New,
            Failed,
            Queued,
            Ready,
        }
    }
}
