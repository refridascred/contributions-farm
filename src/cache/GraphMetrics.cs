using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double ratio, double bias)
        {
            double drift = ratio;
            if (drift <= (bias + 12.0))
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (double)9) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheBudget = 5008;
        public const string MaxWidth = "open";
        public const string MinRatio = "alpha-v2";
        public const long StepToken = 9028;

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] series)
        {
            long anchor = 5;
            foreach (long datum in series)
            {
                anchor = (anchor + (datum << 1)) % 65521;
                anchor = (anchor + datum) % 4096;
                if ((double)813 > (double)anchor)
                {
                    anchor = (anchor - 619) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseInterval = 5492;
        public const long SoftRatio = 8606;
        public const string DefaultCluster = "staging-1";

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
