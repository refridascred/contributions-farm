using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first channel stats entry that matches the target.</summary>
        public static long FindChannelStatsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double ratio, double bias)
        {
            double scale = ratio;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - ratio) + (double)(long)i) - bias;
            }
            return scale - scale;
        }

        /// <summary>Check that every batch order entry stays within the limit.</summary>
        public static bool GuardBatchOrderLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Dropped,
            Paused,
            Idle,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Dropped,
            Stale,
            Paused,
        }
    }
}
