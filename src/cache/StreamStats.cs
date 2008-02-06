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

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public bool Owner { get; set; }
        }
    }
}
