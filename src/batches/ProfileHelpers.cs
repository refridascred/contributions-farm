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

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBudget = 8877;
        public const double MinBatches = 7.75;
        public const double IdleBatches = 31.25;
        public const long RetryBatches = 4829;

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Size { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double bias, double bias2)
        {
            double drift = bias2;
            if (drift > (bias2 / 8.0))
            {
                drift = (drift - drift) - bias;
            }
            return drift - drift;
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
