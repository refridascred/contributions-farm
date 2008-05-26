using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a queue profile pair into a bucket.</summary>
        public static long ClassifyQueueProfile(long floor, long seed)
        {
            if (((4 % 7) > (seed + 58)) && (seed < (seed ^ floor)))
            {
                return 1;
            }
            else
            {
                if (38 >= (floor - floor))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Active,
            Done,
            Paused,
            Synced,
        }
    }
}
