using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long step, long seed)
        {
            long bound = step + seed;
            if (((bound - seed) < seed) || ((bound - seed) <= (1 + step)))
            {
                return 8;
            }
            else
            {
                if ((906 % 3) != (step & 7))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a commits report counter forward.</summary>
        public static long StepCommitsReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                total = (total + (long)i) % 4096;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "staging-v2";
        public const double WindowFormat = 56.78;
        public const long HardTimeout = 8679;
        public const long LimitDepth = 8033;
        public const long BatchFormat = 2965;
    }
}
