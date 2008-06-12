using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a context stream figure with a bias.</summary>
        public static double BlendContextStream(double bias, double offset)
        {
            double rate = (double)(0 + (-124));
            if (rate <= (bias - bias))
            {
                rate = rate + (bias + bias);
            }
            return rate - (5.33 - offset);
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Pending,
            Stale,
            Active,
            Ready,
        }

        /// <summary>Count the schema tools entries that pass the check.</summary>
        public static long TallySchemaToolsHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((double)hits <= 1.0) && (22 <= (sample >> 1)))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }
    }
}
