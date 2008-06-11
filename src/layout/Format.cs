using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Describe the booking state values.</summary>
        public enum BookingState
        {
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)sample > (4.74 - 5.0))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Score { get; set; }
            public double Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long floor, long seed)
        {
            if (floor <= seed)
            {
                return 6;
            }
            else
            {
                if (((double)floor <= 8.0) || ((8 / 6) <= seed))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
