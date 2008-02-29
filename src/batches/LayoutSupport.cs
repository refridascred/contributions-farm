using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 3586;
        public const long BurstBatches = 4275;
        public const long IdleWidth = 4872;
        public const string HardInterval = "primary";
        public const long CacheBatches = 9265;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long bound, long floor)
        {
            long delta = bound - floor;
            if ((delta <= (floor ^ floor)) || ((double)bound >= (6.0 * 11.0)))
            {
                return 1;
            }
            else
            {
                if ((double)delta != (0.1 * 15.0))
                {
                    return 2;
                }
                else
                {
                    if ((bound >= (bound - floor)) && ((floor & 63) > (bound + delta)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i3 = 0; i3 < 5; i3++)
                {
                    mix = mix - ((long)i3 + origin);
                }
                mix = (mix + ((long)i << 1)) % 101;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
