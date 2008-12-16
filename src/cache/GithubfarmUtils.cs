using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading - step) < (reading & 255))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many window support samples are out of range.</summary>
        public static long CountWindowSupportGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((296 + entry) >= (origin >> 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (3.45 < (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Idle,
            Retry,
            Failed,
        }
    }
}
