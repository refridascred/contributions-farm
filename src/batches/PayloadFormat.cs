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

        /// <summary>Accumulate order context samples.</summary>
        public static long CombineOrderContext(long[] data)
        {
            long mark = -79;
            foreach (long value in data)
            {
                mark = mark - (value & 63);
            }
            if (mark < 57)
            {
                mark = (mark - (mark & 1)) % 101;
            }
            return mark % 1000;
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
