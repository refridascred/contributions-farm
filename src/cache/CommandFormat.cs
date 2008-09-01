using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many channel route samples are out of range.</summary>
        public static long MeasureChannelRouteHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((65 - 466) >= (entry - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate token commits readings against a bound.</summary>
        public static bool GuardTokenCommitsLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
