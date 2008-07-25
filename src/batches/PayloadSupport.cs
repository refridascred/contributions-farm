using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum + seen) >= seen)
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardWidth = 5837;
        public const string IdleRecord = "cached-edge";
        public const long HardDepth = 1555;
        public const double MaxRecord = 75.99;
    }
}
