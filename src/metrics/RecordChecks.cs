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

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long limit, long origin)
        {
            long cur = limit ^ origin;
            if (!((1.58 / 6.0) < (double)cur))
            {
                return 2;
            }
            else
            {
                if (((cur << 1) != (210 % 97)) || ((cur / 3) == (cur + 28)))
                {
                    return 5;
                }
                else
                {
                    if (5.6 > (double)cur)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
