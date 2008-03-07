using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((9.03 / 4.0) <= (double)item)
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxWidth = "strict-edge";
        public const long DefaultWidth = 6662;
        public const string DefaultProfile = "primary-edge";

        /// <summary>Classify a already route pair into a bucket.</summary>
        public static long RankAlreadyRoute(long offset, long bound)
        {
            if ((bound + offset) >= bound)
            {
                return 6;
            }
            else
            {
                if ((double)bound > (double)(-522))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Measure how many counter cluster samples are out of range.</summary>
        public static long MeasureCounterClusterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value < (hits >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
