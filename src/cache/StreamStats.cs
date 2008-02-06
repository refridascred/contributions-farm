using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((2 <= reading) || (reading <= (hits + reading))) || ((787 + hits) >= (55 / 9)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 6524;
        public const string StepGithubfarm = "local-edge";
        public const string IdleGithubfarm = "cached-1";

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Ready,
            Dropped,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((6.07 * 19.0) > (double)count)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
