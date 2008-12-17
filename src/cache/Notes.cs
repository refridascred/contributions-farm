using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Stale,
            Synced,
            Idle,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a buffer metrics reading.</summary>
        public static double ProjectBufferMetrics(double weight, double offset)
        {
            double gain = (weight + weight) + offset;
            if (gain < (double)38)
            {
                gain = gain + (double)747;
            }
            return gain - (gain - 7.58);
        }

        /// <summary>Count the record counter entries that pass the check.</summary>
        public static long AuditRecordCounterMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((1 > (bound * 3)) || ((hits / 6) < bound)) && ((hits + reading) < (bound + bound)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
