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

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Size { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleRatio = "open-1";
        public const long StepRatio = 1137;
        public const long LimitProfile = 8087;
        public const string HardProfile = "strict-edge";

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
