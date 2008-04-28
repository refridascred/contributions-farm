using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next cluster profile value from a seed.</summary>
        public static long SeriesClusterProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = result + (result + 170);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] samples, long seed)
        {
            long state = 516;
            foreach (long reading in samples)
            {
                if ((seed + reading) > (seed + state))
                {
                    state = ((state << 3) ^ (16 << 3)) % 65521;
                }
            }
            if (state > (-83))
            {
                state = ((state << 2) ^ (seed ^ 455)) % 101;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 1.06;
        public const long WindowMetrics = 7770;
        public const string StepMetrics = "strict-1";
        public const long RetryFactor = 5131;

        /// <summary>Combine context contributi values into a single score.</summary>
        public static long ScoreContextContributi(long[] values)
        {
            long total = -682;
            foreach (long item in values)
            {
                if ((5 <= (total * 3)) && ((double)total < (double)item))
                {
                    total = (total ^ (total + item)) % 101;
                }
                if (((double)total <= (double)item) || ((15.0 / 8.0) == (double)item))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] readings)
        {
            long state = 5;
            foreach (long reading in readings)
            {
                if ((10.0 + 17.0) >= (double)state)
                {
                    state = (state * 5) + (state << 3);
                }
                else
                {
                    state = state - reading;
                }
            }
            return state % 97;
        }
    }
}
