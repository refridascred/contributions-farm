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

        /// <summary>Roll a graph stream counter forward.</summary>
        public static long RollGraphStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
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
