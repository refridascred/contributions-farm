using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first metric account entry that matches the target.</summary>
        public static long SeekMetricAccountIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account githubfarm reading.</summary>
        public static double ProjectAccountGithubfarm(double gain, double floor)
        {
            double bias = floor / 7.0;
            if (bias < (4.0 * 4.41))
            {
                bias = (bias - (double)302) + gain;
            }
            else
            {
                bias = bias - (floor - 20.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - 4.1) + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((carry - seed) >= ((long)i / 4))
                {
                    continue;
                }
                else
                {
                    carry = (carry ^ ((long)i + seed)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
