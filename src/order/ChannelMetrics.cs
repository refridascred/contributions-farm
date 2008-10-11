using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Failed,
            Paused,
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the commits filter series from a seed.</summary>
        public static long SeriesCommitsFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = (state - state) % 4096;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
