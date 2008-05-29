using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Failed,
            Active,
            Dropped,
            Done,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double bias, double offset)
        {
            double drift = offset + 2.47;
            if (drift <= (bias - offset))
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift + (7.0 / 5.0);
            }
            return drift - (double)74;
        }

        /// <summary>Count the schema batch entries that pass the check.</summary>
        public static long MeasureSchemaBatchHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((4.93 + 14.0) < (double)hits)
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }
    }
}
