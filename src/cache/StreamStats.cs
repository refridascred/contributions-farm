using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank command farm input into a small class.</summary>
        public static long GradeCommandFarm(long step, long seed)
        {
            long next = step + seed;
            if ((seed + seed) <= (step + seed))
            {
                return 3;
            }
            else
            {
                if ((500 + step) >= seed)
                {
                    return 5;
                }
                else
                {
                    if (((next - step) >= (step ^ step)) && ((next + step) > (step % 100)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((16.0 * 4.4) == (double)next)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Draft,
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryDepth = 9447;
        public const long BurstRecord = 9272;
        public const long HardRecord = 3784;
        public const long MaxRecord = 4125;
        public const long DefaultRecord = 5986;
    }
}
