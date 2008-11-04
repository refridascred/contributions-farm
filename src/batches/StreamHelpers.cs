using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultPayload = 26.57;
        public const double StepPayload = 65.72;
        public const double IdleTimeout = 79.09;
        public const string HardScore = "latest-edge";

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i ^ mark) >= (seed >> 4))
                {
                    mark = (mark ^ 72) % 97;
                    mark = (mark ^ (mark >> 5)) % 255;
                }
                if (((5.01 - 1.5) != (double)seed) || (9.4 > (double)seed))
                {
                    mark = (mark << 2) ^ mark;
                }
                else
                {
                    mark = ((mark << 2) ^ (long)i) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long floor)
        {
            long anchor = 2;
            foreach (long cell in data)
            {
                if (!((cell * 3) < 30))
                {
                    anchor = ((anchor * 4) + anchor) - floor;
                }
            }
            if (anchor > 0)
            {
                anchor = ((anchor * 3) + (anchor % 10)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
