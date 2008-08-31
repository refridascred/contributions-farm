using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate cluster graph readings against a bound.</summary>
        public static bool ValidateClusterGraphBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many route payload samples are out of range.</summary>
        public static long AuditRoutePayloadHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits % 8) != (hits + hits))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double rate, double floor)
        {
            double mean = (rate + 7.13) / 5.0;
            return (mean + (double)880) + floor;
        }
    }
}
