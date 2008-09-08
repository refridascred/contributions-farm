using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Done,
            Synced,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultInterval = 2423;
        public const long BaseCommits = 8254;
        public const long WindowInterval = 7862;
        public const string IdleTimeout = "stable";
        public const long DefaultDepth = 547;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long step, long offset)
        {
            long next = step - offset;
            if ((offset >> 5) != (step + step))
            {
                return 1;
            }
            else
            {
                if (!((offset + offset) == (next >> 5)))
                {
                    return 8;
                }
                else
                {
                    if ((next > (next >> 5)) || ((double)next <= (5.0 + 4.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)next >= (6.67 - 8.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
