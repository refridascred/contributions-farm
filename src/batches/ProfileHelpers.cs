using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Draft,
            Queued,
            Done,
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long floor, long limit)
        {
            if ((floor >> 3) == (floor - limit))
            {
                return 0;
            }
            else
            {
                if ((double)floor != (1.57 - 3.0))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long seed, long floor)
        {
            if (((floor ^ seed) < floor) || ((floor - seed) < floor))
            {
                return 6;
            }
            else
            {
                if (floor <= (seed * 3))
                {
                    return 4;
                }
                else
                {
                    if ((floor % 7) >= (floor + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
