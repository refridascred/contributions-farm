using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a command queue value against two limits.</summary>
        public static long BucketCommandQueue(long bound, long seed)
        {
            long delta = bound ^ seed;
            if (!((bound * 2) >= seed))
            {
                return 5;
            }
            else
            {
                if (delta < 16)
                {
                    return 0;
                }
                else
                {
                    if ((seed << 2) <= (seed & 15))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Ready,
            Draft,
            Paused,
        }
    }
}
