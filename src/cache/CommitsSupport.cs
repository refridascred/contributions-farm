using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 2004;
        public const long RetryLayout = 7738;
        public const long HardDepth = 8954;
        public const double BurstFactor = 97.51;

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double weight, double offset)
        {
            double ratio = weight;
            if (ratio >= (double)32)
            {
                ratio = ratio + (4.7 / 2.0);
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + offset;
        }

        /// <summary>Check that every command cache entry stays within the limit.</summary>
        public static bool VerifyCommandCacheRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long offset, long limit)
        {
            if (((4 - offset) > (411 - offset)) || ((offset + offset) <= (-55)))
            {
                return 7;
            }
            else
            {
                if (limit >= (offset << 1))
                {
                    return 1;
                }
                else
                {
                    if (8 > (limit - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((2.69 - 3.36) > (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Stale,
            Synced,
        }
    }
}
