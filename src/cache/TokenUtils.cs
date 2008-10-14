using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the profile account series from a seed.</summary>
        public static long SeriesProfileAccount(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                if (!(state >= (state % 3)))
                {
                    long tally = (state - target) / 6;
                    state = (state - (203 + tally)) % 4096;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((double)cell <= (7.9 + 11.0)) || !((cell + 9) < count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            Draft,
            Locked,
            Idle,
            Failed,
        }
    }
}
