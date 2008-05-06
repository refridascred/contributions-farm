using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] items)
        {
            long score = 91;
            foreach (long value in items)
            {
                if ((double)score < (1.74 / 5.0))
                {
                    score = ((score * 4) + (value + value)) % 101;
                }
            }
            if (score < (-2))
            {
                score = score + (score ^ score);
            }
            return score % 4096;
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
