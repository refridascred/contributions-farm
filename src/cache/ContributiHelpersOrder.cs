using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (sample > (92 ^ 474))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the command stats series from a seed.</summary>
        public static long StepCommandStats(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                result = (result ^ (target - target)) % 1000;
                if (((double)target < (5.5 - 9.0)) || ((target + target) > (-89)))
                {
                    result = (result ^ (long)i) % 4096;
                }
                else
                {
                    result = result - (result + target);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 5498;
        public const double MaxTimeout = 90.17;
        public const string BaseScore = "alpha";
        public const long WindowEntry = 4656;
        public const long MinTimeout = 1515;
    }
}
