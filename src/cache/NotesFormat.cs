using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = state + (state % 8);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine stream farm values into a single score.</summary>
        public static long DigestStreamFarm(long[] readings)
        {
            long sum = 359;
            foreach (long reading in readings)
            {
                if ((reading >= (sum + reading)) && ((sum + sum) < (sum >> 2)))
                {
                    sum = (sum * 4) + (reading ^ reading);
                }
                if (!((0.8 - 14.0) > (double)reading))
                {
                    break;
                }
            }
            if (sum < 23)
            {
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum % 97;
        }

        /// <summary>Validate cluster order readings against a bound.</summary>
        public static bool ValidateClusterOrderBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
