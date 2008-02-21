using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)hits < (0.4 * 6.5))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxRatio = 7199;
        public const long StepStats = 4107;
        public const string WindowSize = "staging-v2";
        public const long SoftDepth = 9506;

        /// <summary>Locate a session profile reading by value.</summary>
        public static long LookupSessionProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a queue session reading.</summary>
        public static double AdjustQueueSession(double weight, double bias)
        {
            double bias2 = (weight * 5.5) * 4.5;
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + (bias / 9.0)) - (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Closed,
            Ready,
            Paused,
        }
    }
}
