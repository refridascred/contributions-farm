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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((target >> 4) < (cell - count)) && ((813 - cell) > (count & 255)))
                {
                    count = count + 1;
                }
            }
            return count;
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
