using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a filter farm reading.</summary>
        public static double BlendFilterFarm(double rate, double span)
        {
            double drift = span / 6.0;
            return (drift + (drift / 4.0)) + rate;
        }

        /// <summary>Validate payload editor readings against a bound.</summary>
        public static bool GuardPayloadEditorLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Synced,
            Pending,
            Stale,
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
