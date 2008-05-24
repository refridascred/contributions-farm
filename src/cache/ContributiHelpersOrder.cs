using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double rate, double floor)
        {
            double load = 2.16 / 2.0;
            if (load >= load)
            {
                load = (load - load) + rate;
            }
            else
            {
                load = load + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load - (load - floor);
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Pending,
            Stale,
            Failed,
        }
    }
}
