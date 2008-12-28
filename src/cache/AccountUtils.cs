using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((matches >> 1) > (matches * 5)) && ((double)matches < (double)(-31)))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] readings, long bound)
        {
            long mix = 3;
            foreach (long value in readings)
            {
                if ((bound > (bound & 3)) || ((bound - (-92)) < (mix << 1)))
                {
                    mix = (((mix << 3) ^ bound) % 1000) - value;
                }
                else
                {
                    mix = mix - mix;
                }
            }
            return mix;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Closed,
            Failed,
            Idle,
            Queued,
            Ready,
        }
    }
}
