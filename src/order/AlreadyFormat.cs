using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a token metrics value against two limits.</summary>
        public static long RankTokenMetrics(long offset, long target)
        {
            if ((target >= (offset & 15)) || (offset < (target << 2)))
            {
                return 8;
            }
            else
            {
                if (((target * 5) >= target) && (target >= (target + target)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry notes pair into a bucket.</summary>
        public static long ClassifyEntryNotes(long bound, long bound2)
        {
            long gap = bound ^ bound2;
            if (bound2 > (57 * 4))
            {
                return 0;
            }
            else
            {
                if ((gap & 1) < (gap % 2))
                {
                    return 5;
                }
                else
                {
                    if ((bound2 % 7) < (gap / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Draft,
            Closed,
            Active,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (datum > (limit & 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
