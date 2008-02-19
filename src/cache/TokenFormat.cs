using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                if (772 > (3 + score))
                {
                    score = (score ^ bound) % 255;
                    continue;
                }
                else
                {
                    score = score ^ (bound + score);
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit session metric readings against a rule.</summary>
        public static long AuditSessionMetricOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((94 >> 3) <= (seed - seed))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Paused,
            Done,
        }
    }
}
