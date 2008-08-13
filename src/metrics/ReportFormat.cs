using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long floor, long target)
        {
            long edge = floor + target;
            if ((floor + edge) == (target + edge))
            {
                return 7;
            }
            else
            {
                if ((97 - edge) > edge)
                {
                    return 5;
                }
                else
                {
                    if (target < (226 + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Locked,
            Stale,
            Ready,
            Active,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((6.64 / 9.0) > (double)cell) || (((81 + cell) == (cell ^ tally)) && ((635 + tally) <= cell)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
