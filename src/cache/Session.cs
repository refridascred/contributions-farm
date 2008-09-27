using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] data, long floor)
        {
            long state = 536;
            foreach (long item in data)
            {
                state = ((state - floor) % 4096) - item;
            }
            return state;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seen <= 1)
                {
                    seen = ((seen + 3) + reading) - origin;
                }
            }
            return seen;
        }

        /// <summary>Blend two contributi metrics measurements.</summary>
        public static double AdjustContributiMetrics(double scale, double span)
        {
            double rate = scale;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (span - span)) + (double)(long)i;
            }
            return rate + (double)11;
        }
    }
}
