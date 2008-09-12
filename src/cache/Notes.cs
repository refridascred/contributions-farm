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

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long offset, long step)
        {
            long step2 = offset + step;
            if ((double)offset > (2.5 * 9.51))
            {
                return 1;
            }
            else
            {
                if ((step2 >> 4) == (94 & 63))
                {
                    return 8;
                }
                else
                {
                    if (((981 % 97) != (offset * 3)) && ((double)step >= (double)offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset - (-70)) != (offset - offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
