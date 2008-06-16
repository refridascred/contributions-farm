using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstCount = 2448;
        public const long StepSpan = 7454;
        public const long BaseInterval = 2969;
        public const long MaxSchema = 115;
        public const long SoftRatio = 5722;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
        }
    }
}
