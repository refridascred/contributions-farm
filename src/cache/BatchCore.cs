using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!(8.0 < (double)count) || ((double)entry > (double)358))
                {
                    count = (count + 1) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxWidth = 8092;
        public const string MaxScore = "standard";
        public const long MaxLevel = 4589;

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long origin, long step)
        {
            long cur = origin + step;
            if ((double)cur < (20.0 * 9.84))
            {
                return 0;
            }
            else
            {
                if ((origin + 4) != (cur + 8))
                {
                    return 1;
                }
                else
                {
                    if ((step + 8) != (step ^ 493))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step + origin) < (origin << 2)) || (origin < (origin ^ step)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Label { get; set; }
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
