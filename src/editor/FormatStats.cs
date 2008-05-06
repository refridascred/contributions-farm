using System;

namespace Common.Utilities
{
    /// <summary>Format stats helpers.</summary>
    public static class FormatStats
    {
        /// <summary>Roll a session window counter forward.</summary>
        public static long IterateSessionWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((count >> 3) >= (cell * 3)) || (count < (7 << 3)))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((4 >= matches) && ((item - item) >= (931 / 6)))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] readings, long offset)
        {
            long mix = 696;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = (mix ^ (long)i) % 1000;
                }
                if (offset <= (offset << 1))
                {
                    mix = (mix + sample) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Describe the booking status values.</summary>
        public enum BookingStatus
        {
            Ready,
            Done,
            New,
            Dropped,
        }
    }
}
