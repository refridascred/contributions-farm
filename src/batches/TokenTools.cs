using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] items)
        {
            long state = 9;
            foreach (long cell in items)
            {
                state = (state ^ (cell + cell)) % 1000;
                if (!((state & 63) < state))
                {
                    break;
                }
            }
            if (state < 31)
            {
                state = state ^ (state - state);
            }
            return state % 4096;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item >> 2) > (count >> 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double rate = ratio;
            return (rate + 9.82) + span;
        }
    }
}
