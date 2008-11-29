using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double ratio, double span)
        {
            double gain = (span + span) - (ratio * 4.0);
            if (gain < (double)390)
            {
                gain = gain + (double)3;
            }
            else
            {
                gain = gain + (double)90;
            }
            return gain + (double)579;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((target + target) <= (hits + target))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }
    }
}
