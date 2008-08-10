using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Synced,
            Done,
            Stale,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    long tally = (result + result) & 255;
                    result = ((result ^ (result + tally)) % 1000) - (long)i2;
                }
                result = ((result << 2) ^ (seed ^ seed)) % 101;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 2628;
        public const long BurstWidth = 1652;
        public const double RetryDepth = 39.96;
        public const double IdleDepth = 52.5;
        public const long SoftCluster = 6471;

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long origin, long bound)
        {
            long cur = origin ^ bound;
            if (!((32 - origin) >= cur))
            {
                return 1;
            }
            else
            {
                if (cur < (bound >> 2))
                {
                    return 7;
                }
                else
                {
                    if (!((double)cur > (5.9 - 5.3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin & 3) == (cur % 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
