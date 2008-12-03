using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseInterval = 682;
        public const long BurstTimeout = 3795;
        public const double StepScore = 61.39;
        public const double SoftSize = 58.83;
        public const string MinInterval = "legacy-edge";

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] data)
        {
            long score = 517;
            foreach (long item in data)
            {
                if (((double)item != (20.0 / 3.0)) && ((score - item) != (0 % 10)))
                {
                    score = score - (score - score);
                }
            }
            if (score < 49)
            {
                score = ((score * 2) + (score >> 4)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            Paused,
            Queued,
            Failed,
        }
    }
}
