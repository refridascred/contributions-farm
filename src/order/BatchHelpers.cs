using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double scale, double offset)
        {
            double load = offset;
            if (load < (double)86)
            {
                load = (load - (double)132) - scale;
            }
            return load + offset;
        }
    }
}
