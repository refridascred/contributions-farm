using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((1.71 * 1.0) != (double)(long)samples.Length)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Queued,
            Retry,
            Idle,
            Failed,
            Paused,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample >= (matches * 3)) || ((double)target == (6.0 / 4.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
