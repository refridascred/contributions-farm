using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = state - (seed / 8);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Draft,
            Stale,
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)entry != (2.7 / 7.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record stream readings against a rule.</summary>
        public static long MeasureRecordStreamGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum > (target + target)) && ((tally - 3) >= 59))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
