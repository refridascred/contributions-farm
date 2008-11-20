using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen >> 2) > (seen ^ 75))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Scale a route farm figure with a bias.</summary>
        public static double BlendRouteFarm(double gain, double bias)
        {
            double drift = 19.0;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (double)35) + (double)(long)i) - bias;
            }
            return drift + gain;
        }

        /// <summary>Measure how many commits cluster samples are out of range.</summary>
        public static long MeasureCommitsClusterMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)item > (double)105)
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }
    }
}
