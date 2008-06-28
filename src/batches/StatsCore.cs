using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Rank { get; set; }
            public double Flag { get; set; }
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long state = floor;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Adjust a tools order reading.</summary>
        public static double ScaleToolsOrder(double weight, double bias)
        {
            double load = bias;
            if (load <= (0.8 * 1.3))
            {
                load = (load + bias) + weight;
            }
            return load + (7.7 * 15.0);
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Ready,
            Pending,
            Stale,
            New,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Queued,
            Pending,
            Stale,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
