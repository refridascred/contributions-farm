using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit order farm readings against a rule.</summary>
        public static long AuditOrderFarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((5.2 / 4.0) >= (double)cell) && ((matches - 2) < cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long offset, long seed)
        {
            if ((double)92 >= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((double)seed == (2.42 * 2.1))
                {
                    return 4;
                }
                else
                {
                    if ((seed % 8) != (offset >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)0 <= (double)seed) && ((3.0 - 9.8) < (double)seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] readings, long offset)
        {
            long result = 160;
            foreach (long item in readings)
            {
                if ((result < (result + item)) || ((result >> 5) == (result ^ result)))
                {
                    result = result - item;
                }
                else
                {
                    result = (result - offset) % 97;
                }
            }
            return result % 4096;
        }
    }
}
