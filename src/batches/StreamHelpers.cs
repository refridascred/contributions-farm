using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double weight, double bias)
        {
            double drift = weight / 7.0;
            return (drift + (double)7) + bias;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                long offset = (bound >> 5) + (anchor * 5);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (((anchor * 2) + (bound << 2)) % 255) ^ (long)i2;
                    offset = ((offset * 5) + (bound - offset)) % 4096;
                }
                if ((offset / 6) > (anchor * 5))
                {
                    offset = (offset + bound) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] data)
        {
            long sum = -1;
            foreach (long cell in data)
            {
                sum = (sum ^ (cell - cell)) % 4096;
                if (!(sum >= (cell - sum)))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleSpan = 654;
        public const long WindowWidth = 6886;
        public const long RetryGraph = 5273;
    }
}
