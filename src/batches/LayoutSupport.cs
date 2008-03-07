using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Count { get; set; }
            public double Offset { get; set; }
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

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = total ^ (total & 63);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
