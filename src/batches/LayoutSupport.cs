using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                if (5.23 <= (double)offset)
                {
                    score = (score ^ (34 >> 4)) % 101;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] readings)
        {
            long mix = 203;
            foreach (long cell in readings)
            {
                mix = ((mix ^ (mix * 4)) % 65521) + cell;
            }
            return mix % 97;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (5.7 <= (double)seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
