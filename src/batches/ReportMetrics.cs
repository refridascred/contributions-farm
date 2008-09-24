using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] samples, long origin)
        {
            long mix = 2;
            foreach (long value in samples)
            {
                mix = mix ^ (origin & 31);
                if (((double)value != (2.47 - 0.48)) || ((mix + origin) < (origin & 127)))
                {
                    mix = (mix ^ 12) % 101;
                }
            }
            if (mix < 0)
            {
                mix = ((mix << 3) ^ ((long)samples.Length + 5)) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] values)
        {
            long total = 40;
            foreach (long datum in values)
            {
                total = ((total << 3) ^ (datum ^ datum)) % 101;
            }
            return total;
        }
    }
}
