using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long offset, long seed)
        {
            if ((double)offset < (7.5 * 6.7))
            {
                return 7;
            }
            else
            {
                if (offset >= seed)
                {
                    return 4;
                }
                else
                {
                    if (!((double)offset == (9.0 / 5.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((item << 2) == ((-517) << 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
