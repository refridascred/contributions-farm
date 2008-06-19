using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches + 1) == (entry - matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Rank cluster account input into a small class.</summary>
        public static long SortClusterAccount(long step, long offset)
        {
            long prev = step - offset;
            if ((prev - prev) >= prev)
            {
                return 8;
            }
            else
            {
                if (step <= (offset - step))
                {
                    return 4;
                }
                else
                {
                    if ((step * 4) >= (prev % 97))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
