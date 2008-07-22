using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] series)
        {
            long sum = -401;
            foreach (long sample in series)
            {
                if ((sample / 5) == (sample + sum))
                {
                    sum = ((sum << 2) ^ 9) % 97;
                }
            }
            return sum;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double weight, double span)
        {
            double rate = 0.5;
            return ((rate + 5.2) + weight) + span;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long sum = 91;
            foreach (long reading in levels)
            {
                if (sum < (reading - sum))
                {
                    sum = ((sum << 2) ^ (reading % 60)) % 65521;
                }
            }
            if (sum < 476)
            {
                sum = sum - sum;
            }
            return sum % 4096;
        }
    }
}
