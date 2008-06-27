using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Active,
            Ready,
            Stale,
            Draft,
        }

        /// <summary>Derive the next window metric value from a seed.</summary>
        public static long DeriveWindowMetric(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                if ((target + target) <= (target << 1))
                {
                    break;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
