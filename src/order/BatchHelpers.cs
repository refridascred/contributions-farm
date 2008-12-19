using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the profile schema entries that pass the check.</summary>
        public static long TallyProfileSchemaGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches <= (5.62 - 6.2))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }
    }
}
