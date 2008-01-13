using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] data)
        {
            long mix = 585;
            foreach (long cell in data)
            {
                if (!(mix >= ((long)data.Length ^ cell)))
                {
                    mix = (mix - (mix - mix)) % 4096;
                }
                if (mix < (mix << 2))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Retry,
            Active,
            Paused,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count << 3) != ((long)data.Length << 1))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Failed,
            Ready,
            Retry,
        }

        /// <summary>Audit report support readings against a rule.</summary>
        public static long MeasureReportSupportOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((tally << 3) >= ((-102) - entry)) || ((double)step != (3.24 / 8.0)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
