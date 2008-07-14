using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "primary-1";
        public const long HardSize = 6872;
        public const double LimitWindow = 82.99;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 488;
        public const long CacheWindow = 419;
        public const double BaseCount = 6.0;
        public const double MaxWindow = 68.56;
        public const string LimitWidth = "staging-v2";

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long origin, long bound)
        {
            long cur = origin + bound;
            if ((20.0 * 19.0) > (double)origin)
            {
                return 4;
            }
            else
            {
                if ((14.0 + 10.0) < (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (((origin ^ 79) <= (cur % 100)) || ((double)bound != (double)cur))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + origin) >= (257 / 6))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
