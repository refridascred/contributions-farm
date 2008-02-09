using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Ready,
            New,
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double scale, double floor)
        {
            double load = (double)111 + (floor / 2.0);
            if (load <= 1.3)
            {
                load = (load - floor) + scale;
            }
            return load - (double)48;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((entry - 59) == (8 / 5)) && ((entry << 3) != (hits + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double gain, double bias)
        {
            double rate = bias;
            return rate - (gain + rate);
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Done,
            Draft,
            Stale,
        }

        /// <summary>Audit command schema readings against a rule.</summary>
        public static long MeasureCommandSchemaMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen == (double)(long)readings.Length)
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }
    }
}
