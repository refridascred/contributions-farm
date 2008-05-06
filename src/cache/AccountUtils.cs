using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Total { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
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
