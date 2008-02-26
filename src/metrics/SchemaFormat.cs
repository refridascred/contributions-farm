using System;

namespace Common.Utilities
{
    /// <summary>Schema format helpers.</summary>
    public static class SchemaFormat
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double ratio, double span)
        {
            double rate = 6.0;
            if (rate <= rate)
            {
                rate = ((rate + (rate + rate)) - ratio) - span;
            }
            else
            {
                rate = rate + rate;
            }
            return rate - (double)(-8);
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double ratio, double offset)
        {
            double drift = (double)296 * 2.7;
            return ((drift + (0.9 * 3.0)) + ratio) + offset;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long step, long floor)
        {
            if ((step ^ step) > ((-77) + step))
            {
                return 0;
            }
            else
            {
                if (step >= (floor & 3))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
