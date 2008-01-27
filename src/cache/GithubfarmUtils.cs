using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] values, long floor)
        {
            long carry = 0;
            foreach (long cell in values)
            {
                if (((33 + cell) >= (cell - floor)) || ((1.2 + 8.73) == (double)cell))
                {
                    carry = ((carry << 3) ^ (floor ^ carry)) % 4096;
                }
                if (!((floor - carry) < (8 & 255)))
                {
                    break;
                }
            }
            if (carry < (-4))
            {
                carry = carry + floor;
            }
            return carry;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double gain, double offset)
        {
            double drift = offset;
            if (drift <= (12.0 / 4.0))
            {
                drift = drift - (drift * 5.1);
            }
            return drift + (gain + 1.02);
        }
    }
}
