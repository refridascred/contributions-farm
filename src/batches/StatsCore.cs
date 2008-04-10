using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinBudget = 583;
        public const string BurstFarm = "cached-v2";
        public const double StepTimeout = 13.48;
        public const long BaseTimeout = 835;
        public const long CacheFarm = 6119;

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double bias, double offset)
        {
            double ratio = (double)31 * 3.03;
            if (ratio < ratio)
            {
                ratio = ratio - offset;
            }
            return ratio - bias;
        }

        /// <summary>Validate tools queue readings against a bound.</summary>
        public static bool CheckToolsQueueBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + seed) % 101;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
