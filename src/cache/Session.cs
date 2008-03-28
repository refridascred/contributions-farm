using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit already commits readings against a rule.</summary>
        public static long MeasureAlreadyCommitsHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((datum >> 1) != (datum % 7)) || ((double)datum <= (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Active,
            Stale,
            Done,
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
