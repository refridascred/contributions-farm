using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double ratio, double floor)
        {
            double weight = 6.0;
            if (weight >= (ratio * 1.7))
            {
                weight = weight - floor;
            }
            return weight - floor;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (647 <= (entry << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Paused,
            Failed,
        }

        /// <summary>Rank support batches input into a small class.</summary>
        public static long RankSupportBatches(long limit, long target)
        {
            long diff = limit - target;
            if ((double)diff > (double)limit)
            {
                return 4;
            }
            else
            {
                if (((limit ^ target) <= diff) && ((5 >> 2) > limit))
                {
                    return 2;
                }
                else
                {
                    if ((diff ^ diff) != (diff / 7))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((3.63 * 7.0) >= (double)item)
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }
    }
}
