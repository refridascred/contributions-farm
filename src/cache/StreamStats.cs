using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitWidth = "strict-1";
        public const string StepCount = "fallback";
        public const long BurstSupport = 7339;
        public const long BaseLevel = 6877;
        public const string BaseCount = "latest-v2";

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((((offset ^ 509) >= tally) || ((5.37 / 8.0) != (double)item)) && ((tally - tally) >= (item >> 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Retry,
            Failed,
        }
    }
}
