using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((((-48) + 250) <= (step ^ reading)) || ((reading & 3) >= (122 / 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next tools account value from a seed.</summary>
        public static long RollToolsAccount(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = ((total ^ total) % 4096) + (long)i2;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
