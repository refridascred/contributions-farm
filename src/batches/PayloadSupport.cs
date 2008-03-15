using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next metrics commits value from a seed.</summary>
        public static long IterateMetricsCommits(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                if ((1.75 * 18.0) < (double)step)
                {
                    state = (state - step) % 4096;
                    state = (state - (94 + state)) % 255;
                }
                else
                {
                    state = ((state * 2) + (2 * 3)) % 65521;
                }
                if ((state >> 5) < state)
                {
                    state = ((state << 2) ^ step) % 4096;
                    break;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
            public double Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
