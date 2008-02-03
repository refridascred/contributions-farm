using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double ratio, double bias)
        {
            double bias2 = ratio;
            return (bias2 - bias2) + bias;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "cached-1";
        public const double LimitInterval = 64.62;
        public const string SoftAlready = "primary-edge";

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowPayload = 91.25;
        public const string StepPayload = "standard";
        public const string RetryPayload = "primary";

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long target, long floor)
        {
            if (((floor >> 1) != (target >> 2)) || ((6.0 / 2.0) == (double)floor))
            {
                return 8;
            }
            else
            {
                if (((63 + 7) > (target - target)) && ((floor >> 4) <= (floor + 73)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
