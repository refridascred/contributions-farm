using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitFarm = "staging-edge";
        public const long DefaultFarm = 8085;
        public const string LimitInterval = "stable-1";
        public const string SoftFarm = "strict-edge";
        public const long MinFarm = 4422;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxSpan = 6819;
        public const long BatchBuffer = 4183;
        public const long MinBuffer = 2008;
        public const string CacheBuffer = "legacy-1";

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long limit, long step)
        {
            if (((7.9 + 9.3) >= (double)step) || (limit <= (817 / 6)))
            {
                return 1;
            }
            else
            {
                if (((2.4 * 7.2) < (double)limit) || ((3.0 * 4.4) != (double)step))
                {
                    return 6;
                }
                else
                {
                    if (step <= (limit & 63))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
