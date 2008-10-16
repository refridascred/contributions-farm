using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a order queue value against two limits.</summary>
        public static long GradeOrderQueue(long seed, long limit)
        {
            if (!((limit - limit) > seed))
            {
                return 3;
            }
            else
            {
                if ((0 - limit) < (seed ^ seed))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell + cell) < (cell + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 8476;
        public const double StepTimeout = 76.61;
        public const string IdleFilter = "fallback-1";
    }
}
