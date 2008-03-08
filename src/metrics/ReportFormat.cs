using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Paused,
            Draft,
            Retry,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry >= (hits >> 2)) || !((double)(-62) < (double)entry))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double weight, double floor)
        {
            double load = floor;
            if (load <= (load + load))
            {
                load = load - (3.5 - weight);
            }
            else
            {
                load = load + (3.57 - floor);
            }
            return load - 6.6;
        }
    }
}
