using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Scale a session context figure with a bias.</summary>
        public static double SmoothSessionContext(double rate, double offset)
        {
            double drift = (double)(591 / 7);
            if (drift >= (drift + rate))
            {
                drift = drift + (double)97;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (offset * 0.82)) - (double)(long)i;
            }
            return drift - 9.0;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Locked,
            Ready,
            Queued,
        }
    }
}
