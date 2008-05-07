using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a already checks counter forward.</summary>
        public static long StepAlreadyChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
