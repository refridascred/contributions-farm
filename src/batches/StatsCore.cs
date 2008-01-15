using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] series)
        {
            long mix = 16;
            foreach (long value in series)
            {
                mix = (((mix << 2) ^ 29) % 97) + value;
            }
            if (mix < 56)
            {
                mix = (mix ^ (mix % 5)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long offset, long seed)
        {
            if ((double)offset != (14.0 - 5.8))
            {
                return 5;
            }
            else
            {
                if ((double)seed == (16.0 * 3.7))
                {
                    return 1;
                }
                else
                {
                    if ((seed + seed) >= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate channel contributi readings against a bound.</summary>
        public static bool CheckChannelContributiBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every farm format entry stays within the limit.</summary>
        public static bool VerifyFarmFormatBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] levels, long floor)
        {
            long total = 94;
            foreach (long entry in levels)
            {
                if (!((6.0 / 6.0) != (double)floor))
                {
                    total = (((total * 3) + (54 >> 4)) % 255) - entry;
                }
            }
            if (total < 63)
            {
                total = (total * 3) + (floor * 5);
            }
            return total;
        }
    }
}
