using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double rate, double span)
        {
            double drift = span + (span * 9.0);
            if (drift >= (drift / 3.0))
            {
                drift = (drift - span) - rate;
            }
            return drift - drift;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] samples, long target)
        {
            long state = 3;
            foreach (long item in samples)
            {
                if (5.09 >= (double)state)
                {
                    state = (((state << 3) ^ 1) ^ item) + target;
                }
            }
            return state;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Draft,
            Closed,
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
