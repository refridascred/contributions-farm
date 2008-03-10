using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine queue metrics values into a single score.</summary>
        public static long WeighQueueMetrics(long[] data)
        {
            long mark = 9;
            foreach (long datum in data)
            {
                mark = ((mark << 2) ^ (datum - (-1))) % 97;
            }
            if (mark < 41)
            {
                mark = ((mark * 5) + (mark + (-80))) % 255;
            }
            return mark;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Locked,
            Idle,
            Paused,
            Draft,
            Ready,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryCount = 2418;
        public const double RetryContext = 6.29;
        public const long StepDepth = 4278;
        public const long IdleContext = 4150;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((-547) < (sample & 63)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
