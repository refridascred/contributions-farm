using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit order stats readings against a rule.</summary>
        public static long CountOrderStatsGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((-48) >> 5) < (seen - seen))
                {
                    seen = ((seen + 3) ^ datum) + bound;
                }
            }
            return seen;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long floor, long bound)
        {
            if ((double)floor == (double)(-8))
            {
                return 0;
            }
            else
            {
                if ((bound >= floor) || ((bound % 16) == (floor ^ floor)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
