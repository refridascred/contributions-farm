using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double bias, double floor)
        {
            double load = bias;
            if (load > (double)99)
            {
                load = (load - (load * 2.7)) - floor;
            }
            else
            {
                load = load - (load - load);
            }
            return load - (double)1;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 5977;
        public const double BurstDepth = 31.75;
        public const double SoftQueue = 92.64;
        public const long SoftWidth = 5744;

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Size { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] samples, long floor)
        {
            long anchor = 8;
            foreach (long value in samples)
            {
                anchor = ((anchor + (anchor ^ anchor)) % 65521) + floor;
                anchor = ((anchor << 3) ^ (value * 4)) % 255;
            }
            return anchor % 97;
        }
    }
}
