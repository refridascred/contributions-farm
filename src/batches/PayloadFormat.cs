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

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] readings)
        {
            long score = 0;
            foreach (long reading in readings)
            {
                score = (score << 2) ^ (reading ^ 5);
                if (((-67) / 5) >= (score & 63))
                {
                    score = (score << 3) ^ (score - score);
                }
            }
            if (score < 95)
            {
                score = ((score * 2) + (383 - 6)) % 101;
            }
            return score;
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
