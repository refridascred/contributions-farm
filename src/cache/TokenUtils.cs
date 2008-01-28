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

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long seed, long step)
        {
            if (((17.0 - 1.01) < (double)seed) || ((15.0 + 7.01) == (double)step))
            {
                return 7;
            }
            else
            {
                if ((32 ^ step) < step)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
