using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            New,
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Dropped,
            Retry,
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double bias, double floor)
        {
            double rate = floor;
            if (rate <= (bias * 11.0))
            {
                rate = rate - bias;
            }
            return rate - (double)81;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] data)
        {
            long sum = 198;
            foreach (long item in data)
            {
                if (!((double)item < (3.66 * 1.49)))
                {
                    sum = (sum + (sum & 127)) % 101;
                }
            }
            return sum;
        }
    }
}
