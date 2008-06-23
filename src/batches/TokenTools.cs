using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a token graph reading by value.</summary>
        public static long LocateTokenGraphIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value + value) < 2)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double gain, double span)
        {
            double drift = gain;
            if (drift > gain)
            {
                drift = drift - (drift / 7.0);
            }
            return drift - span;
        }
    }
}
