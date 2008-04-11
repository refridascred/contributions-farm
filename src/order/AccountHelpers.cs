using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a metric buffer value against two limits.</summary>
        public static long SortMetricBuffer(long offset, long step)
        {
            if ((offset << 3) <= (step & 63))
            {
                return 6;
            }
            else
            {
                if ((step - 6) <= offset)
                {
                    return 2;
                }
                else
                {
                    if (6 > step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a farm profile pair into a bucket.</summary>
        public static long BucketFarmProfile(long seed, long limit)
        {
            if ((seed - limit) != (limit + limit))
            {
                return 1;
            }
            else
            {
                if ((limit / 4) >= (seed << 1))
                {
                    return 6;
                }
                else
                {
                    if (!((seed + seed) != (seed * 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((1.06 / 2.0) == (double)seed) || ((35 & 1) >= (limit * 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 9440;
        public const double BatchTimeout = 39.31;
        public const long SoftBuffer = 5443;
        public const string CacheSpan = "cached-edge";

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Level { get; set; }
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((double)(long)values.Length == (4.32 - 18.0)) || (reading >= (reading + reading)))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
