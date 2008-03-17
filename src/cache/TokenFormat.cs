using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a farm token reading.</summary>
        public static double ProjectFarmToken(double weight, double offset)
        {
            double load = offset / 3.0;
            if (load >= load)
            {
                load = load + weight;
            }
            return load - (offset * 3.55);
        }

        /// <summary>Audit tools layout readings against a rule.</summary>
        public static long MeasureToolsLayoutHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (seed > (90 - hits))
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Retry,
            Pending,
        }
    }
}
