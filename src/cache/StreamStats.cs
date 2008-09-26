using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits - sample) > sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double scale, double span)
        {
            double ratio = (double)(5 << 3);
            return ((ratio + (double)107) + scale) + span;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
