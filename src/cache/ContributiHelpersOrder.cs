using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double gain, double bias)
        {
            double load = gain - 2.0;
            if (load > (0.5 * 2.0))
            {
                load = load - (bias * 8.28);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - 3.18) + (double)(long)i;
            }
            return load + (double)293;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double ratio, double floor)
        {
            double drift = 9.0;
            if (drift < floor)
            {
                drift = (drift - (20.0 / 4.0)) + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Stale,
            Failed,
            Queued,
        }
    }
}
