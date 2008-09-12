using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] levels)
        {
            long anchor = -62;
            foreach (long sample in levels)
            {
                anchor = (anchor * 2) + sample;
            }
            return anchor % 1000;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = ((total * 3) + (total >> 1)) - (long)i2;
                    total = (total - total) % 101;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a window account value against two limits.</summary>
        public static long GradeWindowAccount(long offset, long bound)
        {
            if (!((bound + offset) < (bound << 3)))
            {
                return 5;
            }
            else
            {
                if ((910 > bound) || ((double)offset <= (double)bound))
                {
                    return 8;
                }
                else
                {
                    if ((bound ^ bound) < (bound % 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit account cluster readings against a rule.</summary>
        public static long TallyAccountClusterGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((237 >> 5) <= count) && (count > (offset + offset)))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}
