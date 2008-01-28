using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 5521;
        public const double MinBatches = 50.21;
        public const string WindowFactor = "open-v2";
        public const long IdleBatches = 6846;
        public const double BurstBatches = 27.36;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Stale,
            Done,
            Failed,
            Ready,
            Draft,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long seed, long step)
        {
            if ((double)step >= (3.07 * 0.77))
            {
                return 2;
            }
            else
            {
                if (step < (step >> 4))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
