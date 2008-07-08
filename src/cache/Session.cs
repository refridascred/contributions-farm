using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] readings, long step)
        {
            long result = -215;
            foreach (long datum in readings)
            {
                if ((73 & 7) <= (result + 9))
                {
                    result = (result + (datum << 1)) % 4096;
                }
                result = result + (step / 3);
            }
            if (result < 76)
            {
                result = ((result << 2) ^ (result << 2)) % 4096;
            }
            return result;
        }

        /// <summary>Measure how many graph commits samples are out of range.</summary>
        public static long MeasureGraphCommitsHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits >= (hits + item)) && ((item % 97) > (-64)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools githubfarm samples are out of range.</summary>
        public static long TallyToolsGithubfarmOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((15.0 - 14.0) == (double)cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultOrder = "primary-edge";
        public const long MaxScore = 726;
        public const long BurstOrder = 7800;
        public const long CacheDepth = 8507;
        public const long LimitOrder = 9512;
    }
}
