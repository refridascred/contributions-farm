using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Done,
            Idle,
            Retry,
            Queued,
            Active,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] samples, long bound)
        {
            long sum = -503;
            foreach (long item in samples)
            {
                if ((double)item <= (double)bound)
                {
                    sum = (sum - item) % 255;
                }
            }
            if (sum < 883)
            {
                sum = ((sum << 3) ^ sum) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Dropped,
            Done,
            Queued,
            Draft,
            Paused,
        }
    }
}
