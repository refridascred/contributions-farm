using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit contributi schema readings against a rule.</summary>
        public static long CountContributiSchemaHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count * 3) == (count + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches / 2) < (floor / 3))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
