using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((tally >= (item / 4)) && ((double)tally >= (8.32 / 8.0))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] levels)
        {
            long sum = 579;
            foreach (long cell in levels)
            {
                sum = sum ^ cell;
                if ((sum >> 2) == (sum ^ 5))
                {
                    sum = sum - (sum / 6);
                }
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a editor metric sample.</summary>
        public static long LocateEditorMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metric commits input into a small class.</summary>
        public static long BucketMetricCommits(long origin, long limit)
        {
            if ((3.62 * 16.0) < (double)origin)
            {
                return 3;
            }
            else
            {
                if ((6.7 - 14.0) > (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((limit / 6) < (limit & 255))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((3.4 * 7.0) >= (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                if ((step / 4) >= mix)
                {
                    break;
                }
                if (!((step - step) < (long)i))
                {
                    mix = mix ^ (step ^ mix);
                }
                if ((step + step) != (long)i)
                {
                    mix = (mix * 2) + step;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
