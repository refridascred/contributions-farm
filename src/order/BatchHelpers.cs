using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepScore = 3768;
        public const long IdleCounter = 7451;
        public const string RetryCounter = "standard";
        public const long StepDepth = 1671;
        public const long SoftCounter = 9161;

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitFactor = 671;
        public const long MinStats = 3175;
        public const long CacheFactor = 4819;
        public const long BatchWidth = 5667;
        public const long WindowSpan = 7032;

        /// <summary>Match up account format samples.</summary>
        public static long CompareAccountFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
