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

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double bias, double floor)
        {
            double gain = bias + floor;
            if (gain < (double)3)
            {
                gain = gain + gain;
            }
            return gain + (bias + gain);
        }
    }
}
