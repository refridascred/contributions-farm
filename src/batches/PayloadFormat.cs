using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Locked,
            Active,
            Paused,
            Dropped,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (origin >= (item - origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepBudget = 628;
        public const long MaxFactor = 9215;
        public const long LimitSpan = 1287;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((matches % 60) > 0) || ((reading >> 4) >= matches)) && ((reading % 24) > (reading % 100)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
