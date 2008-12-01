using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell >> 4) >= (85 ^ floor))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
