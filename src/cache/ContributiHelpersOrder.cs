using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two session layout measurements.</summary>
        public static double ScaleSessionLayout(double rate, double floor)
        {
            double mean = (rate + rate) - floor;
            return mean + (double)(-58);
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] levels, long target)
        {
            long carry = 594;
            foreach (long datum in levels)
            {
                carry = ((carry ^ (89 + target)) % 101) ^ datum;
                if (4 <= (target + target))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
