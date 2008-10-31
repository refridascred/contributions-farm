using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)count <= (3.71 + 17.0))
                {
                    count = ((count + 2) - datum) - seed;
                }
            }
            return count;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Active,
            Draft,
        }
    }
}
