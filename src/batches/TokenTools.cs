using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Pending,
            New,
            Queued,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(target <= (tally + 6)) || ((double)7 > (double)tally))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
