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

        /// <summary>Count the checks command entries that pass the check.</summary>
        public static long TallyChecksCommandGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((7.8 - 9.38) >= (double)seen)
                {
                    seen = ((seen + 1) - sample) + bound;
                }
            }
            return seen;
        }
    }
}
