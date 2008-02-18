using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            New,
            Retry,
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                if (!(((59 * 2) < (seed << 3)) && ((-2) >= (long)i)))
                {
                    result = ((result * 2) + (result / 7)) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
