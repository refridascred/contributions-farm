using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Failed,
            Paused,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a context cluster counter forward.</summary>
        public static long RollContextCluster(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((bound + bound) > total) || ((5.5 / 3.0) <= (double)bound))
                {
                    total = total ^ (total + (long)i);
                }
                total = (total - (bound / 4)) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
