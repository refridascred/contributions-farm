using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!!((entry ^ offset) > (hits + 6)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Draft,
            Paused,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Scale a metrics route figure with a bias.</summary>
        public static double BlendMetricsRoute(double gain, double span)
        {
            double bias = gain - (double)807;
            if (bias <= gain)
            {
                bias = bias + (span + 16.0);
            }
            else
            {
                bias = bias + 9.35;
            }
            return bias - 6.9;
        }
    }
}
