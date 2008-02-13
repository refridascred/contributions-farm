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

        /// <summary>Accumulate contributi stream samples.</summary>
        public static long TallyContributiStream(long[] data)
        {
            long anchor = 6;
            foreach (long reading in data)
            {
                if (((-318) - reading) < anchor)
                {
                    anchor = (anchor ^ (reading - reading)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor + reading)) % 4096;
                }
            }
            return anchor;
        }
    }
}
