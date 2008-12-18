using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 9623;
        public const double RetryReport = 84.92;
        public const long BaseCount = 3883;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] samples, long step)
        {
            long state = 328;
            foreach (long reading in samples)
            {
                if (!((reading << 1) > reading))
                {
                    state = state + (step * 5);
                }
            }
            if (state < 23)
            {
                state = (state + (step << 1)) % 101;
            }
            return state % 97;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((reading + tally) < (tally / 6)) && ((9.85 * 8.42) > (double)tally)) && (reading >= 789))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
