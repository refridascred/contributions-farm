using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double gain, double offset)
        {
            double load = gain;
            if (load < offset)
            {
                load = load - load;
            }
            return load + (double)4;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            Active,
            New,
            Pending,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit checks cache readings against a rule.</summary>
        public static long CountChecksCacheHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((cell - 30) == (tally * 4)) && ((9.8 / 8.0) < (double)cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
