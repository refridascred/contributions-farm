using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seed / 5) <= (seen ^ 197))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values)
        {
            long anchor = 143;
            foreach (long datum in values)
            {
                if ((long)values.Length > (anchor + anchor))
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = (anchor - (datum / 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long limit, long seed)
        {
            if (9.0 < (double)seed)
            {
                return 0;
            }
            else
            {
                if ((-9) < seed)
                {
                    return 1;
                }
                else
                {
                    if ((seed > (limit & 7)) || ((limit + limit) <= (seed & 31)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed != (3.8 - 0.4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
