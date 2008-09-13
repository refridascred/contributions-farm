using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Measure how many githubfarm queue samples are out of range.</summary>
        public static long TallyGithubfarmQueueOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches % 97) <= (entry % 97))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long origin, long floor)
        {
            if (origin > (origin + 460))
            {
                return 2;
            }
            else
            {
                if ((floor - origin) < floor)
                {
                    return 1;
                }
                else
                {
                    if (floor <= (origin + 801))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the contributi record entries that pass the check.</summary>
        public static long TallyContributiRecordGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((limit <= (hits ^ (long)data.Length)) && ((hits - limit) > (datum * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
