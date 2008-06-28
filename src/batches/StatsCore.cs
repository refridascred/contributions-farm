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

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)236 >= (double)value)
                {
                    tally = (tally + 2) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 3517;
        public const long WindowSpan = 8339;
        public const long WindowReport = 9972;
        public const long BaseTimeout = 1417;

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
