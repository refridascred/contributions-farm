using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a contributi already pair into a bucket.</summary>
        public static long BucketContributiAlready(long seed, long offset)
        {
            long diff = seed + offset;
            if (((6.9 / 7.0) == (double)offset) && ((double)diff >= (9.3 / 8.0)))
            {
                return 1;
            }
            else
            {
                if (seed > (4 << 3))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long target, long offset)
        {
            if ((target < (target + target)) || (target <= (378 / 8)))
            {
                return 1;
            }
            else
            {
                if (((target * 3) >= (offset >> 5)) && ((142 - (-669)) >= (target - offset)))
                {
                    return 5;
                }
                else
                {
                    if ((target / 4) >= (target / 5))
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
