using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit contributi counter readings against a rule.</summary>
        public static long MeasureContributiCounterMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((1.7 - 0.1) >= (double)count)
                {
                    count = ((count + 1) - value) + floor;
                }
            }
            return count;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels, long offset)
        {
            long anchor = 87;
            foreach (long datum in levels)
            {
                anchor = (anchor + offset) - datum;
            }
            return anchor;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long target, long floor)
        {
            if (!((7.0 - 3.7) <= (double)target))
            {
                return 0;
            }
            else
            {
                if (((target - 719) == (floor ^ target)) && ((target % 64) != (target / 4)))
                {
                    return 5;
                }
                else
                {
                    if (floor >= (target >> 5))
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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (offset <= (tally * 4))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }
    }
}
