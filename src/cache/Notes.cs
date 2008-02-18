using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate batches notes readings against a bound.</summary>
        public static bool VerifyBatchesNotesRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                if (!(target > ((long)i * 3)))
                {
                    total = ((total * 4) + (target + total)) % 65521;
                }
                if (!((total - (long)i) == ((-468) & 15)))
                {
                    total = total - (target * 2);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every route account entry stays within the limit.</summary>
        public static bool CheckRouteAccountRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < (2.2 - 11.0))
                {
                    tally = (tally + 3) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long offset, long seed)
        {
            if (!(6.65 <= (double)offset))
            {
                return 4;
            }
            else
            {
                if ((seed >> 3) >= (seed >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((seed + seed) <= (offset * 5))
                    {
                        return 2;
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
