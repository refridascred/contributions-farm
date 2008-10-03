using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double gain, double bias)
        {
            double bias2 = bias * 4.34;
            return (bias2 - (7.3 - bias)) + gain;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((20.0 + 9.81) < (double)datum)
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }
    }
}
