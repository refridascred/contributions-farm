using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = state + (floor % 8);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseScore = 3741;
        public const double BaseBudget = 55.91;
        public const long BatchSupport = 570;

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxSize = 4863;
        public const double CacheRoute = 46.64;
        public const long StepFactor = 9591;
        public const double IdleCount = 37.97;
    }
}
