using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate queue profile readings against a bound.</summary>
        public static bool ValidateQueueProfileLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Dropped,
            Ready,
            Failed,
            Stale,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (step <= 50)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Blend two graph command measurements.</summary>
        public static double SmoothGraphCommand(double bias, double bias2)
        {
            double rate = (bias2 - 8.76) * 2.0;
            if (rate <= bias)
            {
                rate = rate + (0.85 / 5.0);
            }
            return rate + (rate + rate);
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            New,
            Pending,
            Active,
            Failed,
            Stale,
        }
    }
}
