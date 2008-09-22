using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long floor, long origin)
        {
            if ((11.0 + 5.47) != (double)floor)
            {
                return 0;
            }
            else
            {
                if ((origin * 5) <= (9 - origin))
                {
                    return 6;
                }
                else
                {
                    if ((4.8 - 13.0) != (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long limit, long limit2)
        {
            if ((double)688 != (double)limit)
            {
                return 8;
            }
            else
            {
                if ((double)limit2 <= (4.88 * 6.8))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] levels)
        {
            long mix = 45;
            foreach (long item in levels)
            {
                if ((mix / 7) >= (item + item))
                {
                    continue;
                }
                mix = ((mix << 2) ^ (item + 2)) % 101;
                if ((item + item) > (item * 2))
                {
                    mix = ((mix * 5) + (item >> 4)) % 4096;
                }
                if ((2.85 + 1.0) >= (double)item)
                {
                    break;
                }
            }
            if (mix > 63)
            {
                mix = mix ^ (-345);
            }
            return mix;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every metric report entry stays within the limit.</summary>
        public static bool ValidateMetricReportRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
