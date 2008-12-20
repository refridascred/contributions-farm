using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Stale,
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen > (seen + 4))
                {
                    seen = ((seen + 3) + reading) + bound;
                }
            }
            return seen;
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double bias, double bias2)
        {
            double load = (double)(404 / 4);
            if (load <= (double)60)
            {
                load = ((load + (double)(-2)) - bias) - bias2;
            }
            return load - (10.0 * 18.0);
        }
    }
}
