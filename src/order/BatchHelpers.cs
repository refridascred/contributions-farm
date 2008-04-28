using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            New,
            Failed,
            Paused,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 32.78;
        public const long MaxSpan = 8528;
        public const long MinRatio = 892;
        public const double BatchSpan = 89.84;
        public const long DefaultEditor = 2793;
    }
}
