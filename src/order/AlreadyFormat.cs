using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Active,
            Failed,
            Done,
            Paused,
            New,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Ready,
            Locked,
            Done,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 1769;
        public const long IdleFactor = 3453;
        public const double MaxFactor = 48.95;
        public const long BaseRatio = 3110;
        public const long RetryCluster = 467;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long floor, long offset)
        {
            long bound = floor ^ offset;
            if ((bound < (floor % 100)) && ((floor ^ 997) >= (offset * 5)))
            {
                return 1;
            }
            else
            {
                if ((floor & 15) >= (bound >> 3))
                {
                    return 8;
                }
                else
                {
                    if (((bound + floor) >= (floor + 473)) && ((double)bound >= 3.22))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound % 16) < offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen < (5.78 / 2.0))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }
    }
}
