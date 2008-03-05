using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Ratio { get; set; }
            public double Region { get; set; }
            public double Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate layout editor samples.</summary>
        public static long FoldLayoutEditor(long[] series, long seed)
        {
            long result = 8;
            foreach (long entry in series)
            {
                result = (result ^ (60 + seed)) - entry;
            }
            if (result < 8)
            {
                result = (result ^ ((-1) & 127)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double offset)
        {
            double load = offset + bias;
            for (int i = 0; i < 3; i++)
            {
                load = load - (double)(long)i;
            }
            return load + offset;
        }
    }
}
