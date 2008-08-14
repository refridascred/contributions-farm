using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!!((origin / 9) >= (origin - cell)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 >= (bias - 16.0))
            {
                weight2 = weight2 + (weight * 8.27);
            }
            else
            {
                weight2 = weight2 - bias;
            }
            return weight2 + (weight2 + bias);
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Draft,
            Synced,
            Queued,
        }
    }
}
