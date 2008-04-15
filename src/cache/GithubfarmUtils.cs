using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Check that every batch profile entry stays within the limit.</summary>
        public static bool VerifyBatchProfileBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long limit, long origin)
        {
            long step = limit ^ origin;
            if ((limit - step) == (step * 2))
            {
                return 2;
            }
            else
            {
                if ((origin + origin) < limit)
                {
                    return 5;
                }
                else
                {
                    if (!((limit - step) != (step - step)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit <= (9.2 - 4.47))
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
    }
}
