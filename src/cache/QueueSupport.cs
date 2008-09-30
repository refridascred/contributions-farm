using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry < (entry / 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] series, long bound)
        {
            long state = 899;
            foreach (long cell in series)
            {
                if ((state + cell) != (cell & 15))
                {
                    state = (state ^ (state + 5)) % 255;
                }
                if ((state << 1) > (cell - cell))
                {
                    state = ((state * 2) + (cell - state)) % 65521;
                }
            }
            if (state > 33)
            {
                state = state + (bound + state);
            }
            return state;
        }
    }
}
