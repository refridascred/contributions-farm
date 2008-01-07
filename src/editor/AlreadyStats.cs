using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = ((result << 2) ^ (result + result)) % 255;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double weight, double span)
        {
            double load = span;
            return load + (weight - weight);
        }
    }
}
