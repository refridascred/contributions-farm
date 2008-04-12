using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Active,
            Paused,
            Ready,
            Locked,
            Idle,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepDepth = 603;
        public const double LimitFactor = 70.27;
        public const long IdleNotes = 8096;
        public const string BaseNotes = "open-edge";

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((datum / 7) != (datum * 3)) || (((9.92 * 8.27) == (double)datum) && (3.0 <= (double)datum)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
