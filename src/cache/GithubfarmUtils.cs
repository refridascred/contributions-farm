using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Measure how many metrics batches samples are out of range.</summary>
        public static long CountMetricsBatchesMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry % 97) == (1 & 15))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double rate, double floor)
        {
            double drift = floor;
            if (drift >= (floor / 5.0))
            {
                drift = drift - 0.9;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift + (rate + drift);
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
