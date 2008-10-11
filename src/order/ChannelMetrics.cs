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

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits > ((long)levels.Length * 3)) && (((item / 4) > (hits + 3)) || (hits < (item / 3))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
