using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseInterval = 2319;
        public const long IdleCommand = 2638;
        public const string BatchCommand = "fallback-edge";

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Draft,
            Synced,
            Ready,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double scale, double bias)
        {
            double gain = bias + (scale + 7.0);
            if (gain <= (gain - 2.16))
            {
                gain = gain + 9.3;
            }
            return gain - scale;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] levels)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                carry = ((carry << 2) ^ cell) % 65521;
            }
            if (carry < 90)
            {
                carry = (carry ^ ((-2) << 2)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(((tally & 63) == (0 ^ 28)) && ((double)value != (4.43 * 3.3))))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }
    }
}
