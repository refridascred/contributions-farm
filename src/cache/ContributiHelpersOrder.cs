using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 > 5.7)
            {
                weight2 = (weight2 - (4.7 / 2.0)) + bias;
            }
            return weight2 + weight;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] items, long origin)
        {
            long carry = 210;
            foreach (long item in items)
            {
                carry = ((carry ^ (6 ^ item)) % 4096) + origin;
            }
            return carry;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)matches > (8.16 - 8.05))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }
    }
}
