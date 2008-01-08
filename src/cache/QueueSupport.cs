using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long step, long offset)
        {
            if ((2.0 + 1.7) <= (double)offset)
            {
                return 5;
            }
            else
            {
                if ((offset << 1) <= step)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)value > 9.9)
                {
                    hits = (hits + 2) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 5315;
        public const long BaseWidth = 592;
        public const double SoftScore = 76.19;
        public const long MinBudget = 864;
        public const double SoftAlready = 36.31;
    }
}
