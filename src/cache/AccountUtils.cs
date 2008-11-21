using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate profile cache samples.</summary>
        public static long FoldProfileCache(long[] levels)
        {
            long score = 7;
            foreach (long entry in levels)
            {
                if (((double)(-717) >= (double)score) || ((entry + entry) >= 36))
                {
                    score = score + (score * 5);
                }
            }
            if (score < 3)
            {
                score = (score * 2) + (score + score);
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultInterval = 0.83;
        public const long LimitFarm = 9271;
        public const double IdleFarm = 81.62;
        public const string BurstInterval = "fallback-v2";
        public const long StepFarm = 7386;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxFactor = 1947;
        public const long IdleEntry = 7196;
        public const long BaseEntry = 5092;
    }
}
