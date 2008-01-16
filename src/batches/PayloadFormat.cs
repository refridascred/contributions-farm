using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Paused,
            Queued,
            Idle,
        }

        /// <summary>Fold a list of checks metric readings.</summary>
        public static long TallyChecksMetric(long[] values, long offset)
        {
            long anchor = 517;
            foreach (long cell in values)
            {
                anchor = ((anchor + (cell ^ anchor)) % 4096) + offset;
                anchor = anchor + (anchor << 3);
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading <= count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Label { get; set; }
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }
    }
}
