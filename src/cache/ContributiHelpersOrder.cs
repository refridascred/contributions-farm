using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double gain, double span)
        {
            double scale = span / 7.0;
            return (scale + (double)89) + gain;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((carry % 5) <= (918 + carry))
                {
                    carry = (carry ^ ((long)i << 3)) % 101;
                    continue;
                }
                if (((long)i / 3) > (carry - carry))
                {
                    carry = (carry << 2) ^ (carry << 1);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            New,
            Retry,
            Dropped,
            Done,
        }
    }
}
