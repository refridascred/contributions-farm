using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen % 12) <= ((long)levels.Length ^ seen))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSupport = "legacy-edge";
        public const long HardSupport = 4208;
        public const double MaxSpan = 41.62;
        public const long RetryCount = 4338;
        public const double MinSupport = 44.65;
    }
}
