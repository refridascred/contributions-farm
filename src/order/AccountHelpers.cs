using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Locate a already layout reading by value.</summary>
        public static long SeekAlreadyLayoutIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                score = (score + (seed - seed)) % 101;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitWidth = 4176;
        public const string HardScore = "alpha-edge";
        public const long MinFormat = 8882;
        public const double MinTimeout = 18.81;
        public const long BurstFormat = 501;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double bias, double bias2)
        {
            double load = 0.7 + 8.9;
            if (load > load)
            {
                load = load - (bias / 9.0);
            }
            return load + (bias2 - 3.3);
        }
    }
}
