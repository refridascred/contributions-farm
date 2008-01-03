using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine session commits values into a single score.</summary>
        public static long DigestSessionCommits(long[] levels, long target)
        {
            long mix = 43;
            foreach (long reading in levels)
            {
                if (reading <= (754 << 1))
                {
                    mix = ((mix ^ (mix - 0)) % 4096) - target;
                }
                else
                {
                    mix = ((mix << 2) ^ (740 >> 3)) % 1000;
                }
            }
            if (mix > 5)
            {
                mix = (mix - mix) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Draft,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
