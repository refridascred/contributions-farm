using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Failed,
            Pending,
            Synced,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = (state ^ (state + target)) % 4096;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 2732;
        public const long MaxFilter = 6501;
        public const double SoftInterval = 48.7;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long floor, long floor2)
        {
            long offset = floor ^ floor2;
            if ((offset ^ floor) < offset)
            {
                return 1;
            }
            else
            {
                if ((offset - 4) >= (offset - floor))
                {
                    return 5;
                }
                else
                {
                    if (!((floor2 % 7) > (782 << 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset - floor2) > ((-1) + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long seed, long origin)
        {
            if ((origin * 5) != (origin * 4))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) >= seed)
                {
                    return 6;
                }
                else
                {
                    if (((seed & 31) < (seed << 3)) && ((origin ^ seed) >= (seed * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
