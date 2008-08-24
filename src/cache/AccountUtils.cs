using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count << 1) >= value)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit schema graph readings against a rule.</summary>
        public static long TallySchemaGraphHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((6.7 / 4.0) >= (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long seed, long origin)
        {
            long offset = seed ^ origin;
            if ((2.63 + 18.0) <= (double)seed)
            {
                return 3;
            }
            else
            {
                if ((offset - 62) > origin)
                {
                    return 7;
                }
                else
                {
                    if ((515 > origin) || ((origin + seed) <= origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((6.75 / 7.0) < (double)offset) || ((offset * 3) < (offset + origin)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
