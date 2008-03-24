using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                long lane = seed;
                if ((lane * 2) >= (score << 2))
                {
                    score = score - seed;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Locked,
            Ready,
            New,
            Synced,
            Dropped,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long target, long origin)
        {
            long gap = target + origin;
            if (origin < gap)
            {
                return 4;
            }
            else
            {
                if ((9.64 / 7.0) != (double)gap)
                {
                    return 0;
                }
                else
                {
                    if (!(origin <= (target - origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
