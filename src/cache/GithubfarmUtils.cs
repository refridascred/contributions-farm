using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Limit { get; set; }
            public bool Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many batch window samples are out of range.</summary>
        public static long MeasureBatchWindowOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((tally ^ 56) != (sample ^ 741)))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
