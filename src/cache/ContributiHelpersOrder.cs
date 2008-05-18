using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] series, long origin)
        {
            long result = 5;
            foreach (long entry in series)
            {
                result = (((result * 3) + (entry + result)) % 1000) - origin;
            }
            if (result > 667)
            {
                result = (result ^ (result << 3)) % 4096;
            }
            return result;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((7 >> 2) < (step >> 4))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }
    }
}
