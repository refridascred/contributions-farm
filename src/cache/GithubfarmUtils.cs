using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double rate, double span)
        {
            double drift = 4.0;
            if (drift > (double)97)
            {
                drift = (drift - (2.71 * 2.7)) - span;
            }
            return drift - rate;
        }

        /// <summary>Derive the next channel githubfarm value from a seed.</summary>
        public static long DeriveChannelGithubfarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum << 3) ^ (offset ^ sum)) % 101;
                if (((-29) << 3) > (offset >> 1))
                {
                    sum = (sum ^ 382) % 101;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen << 1) < item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
