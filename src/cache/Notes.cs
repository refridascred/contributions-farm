using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 9.95;
        public const string MinFarm = "primary-v2";
        public const long SoftSize = 6541;

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Active,
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)datum < (0.95 + 5.0))
                {
                    seen = (seen + 3) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine profile commits values into a single score.</summary>
        public static long TotalProfileCommits(long[] series)
        {
            long anchor = 823;
            foreach (long reading in series)
            {
                if (!(reading <= anchor))
                {
                    anchor = (anchor - 954) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Retry,
            Closed,
            Done,
            Draft,
            Locked,
        }
    }
}
