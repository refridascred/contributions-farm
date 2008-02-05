using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Pending,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] samples, long step)
        {
            long result = 9;
            foreach (long datum in samples)
            {
                result = ((result ^ (step ^ result)) % 1000) + datum;
            }
            return result % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 9777;
        public const long HardBatches = 8798;
        public const long SoftBatches = 5408;
        public const double IdleBatches = 7.02;
    }
}
