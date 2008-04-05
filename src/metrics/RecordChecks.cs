using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Describe the booking phase values.</summary>
        public enum BookingPhase
        {
            New,
            Failed,
            Locked,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((726 + 3) <= (value & 63))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long seed, long offset)
        {
            long span = seed - offset;
            if (((9.92 - 2.7) >= (double)seed) || ((seed - seed) > (span - span)))
            {
                return 7;
            }
            else
            {
                if ((712 + offset) != (span * 5))
                {
                    return 8;
                }
                else
                {
                    if ((4.4 - 0.5) > (double)span)
                    {
                        return 2;
                    }
                    else
                    {
                        if (18.0 > (double)span)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
