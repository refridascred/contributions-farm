using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            Synced,
            Pending,
            Done,
        }

        /// <summary>Rank contributi account input into a small class.</summary>
        public static long RankContributiAccount(long limit, long bound)
        {
            if (((bound + bound) < bound) && ((double)24 < (double)bound))
            {
                return 5;
            }
            else
            {
                if ((bound + limit) != (bound - limit))
                {
                    return 4;
                }
                else
                {
                    if ((5.0 <= (double)bound) || ((bound - bound) <= limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the schema cluster entries that pass the check.</summary>
        public static long CountSchemaClusterOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((((step * 2) <= (step - 75)) || (seen <= step)) && ((seen << 2) <= reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
