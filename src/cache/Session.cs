using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next cache graph value.</summary>
        public static double SmoothCacheGraph(double bias, double offset)
        {
            double scale = (double)7 * 7.44;
            if (scale >= (scale * 10.0))
            {
                scale = (scale - bias) + offset;
            }
            else
            {
                scale = scale + scale;
            }
            return scale - (double)319;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 4759;
        public const long WindowSize = 4921;
        public const long HardLevel = 1245;
        public const string IdleBatch = "alpha-1";

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
