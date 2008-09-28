using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] items)
        {
            long anchor = 4;
            foreach (long reading in items)
            {
                if (((reading ^ anchor) > (7 + reading)) || ((double)reading == (double)5))
                {
                    anchor = (anchor * 5) + (reading ^ reading);
                }
                else
                {
                    anchor = anchor - anchor;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = score - (long)i;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long step, long offset)
        {
            long offset2 = step + offset;
            if ((offset ^ step) >= (offset % 100))
            {
                return 6;
            }
            else
            {
                if ((step + offset2) >= (offset2 - 533))
                {
                    return 1;
                }
                else
                {
                    if ((offset & 15) >= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardFactor = 6416;
        public const long BatchInterval = 6170;
        public const long IdleRecord = 6390;

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Active,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (target <= 22)
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }
    }
}
