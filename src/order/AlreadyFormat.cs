using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a batch channel reading by value.</summary>
        public static long FindBatchChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Stale,
            Queued,
            Pending,
            Draft,
            New,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((entry + hits) < (entry / 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double weight, double floor)
        {
            double load = weight + (double)625;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + weight) + (double)(long)i) + floor;
            }
            return load - (double)(-69);
        }
    }
}
