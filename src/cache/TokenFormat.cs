using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a already filter figure with a bias.</summary>
        public static double BlendAlreadyFilter(double scale, double offset)
        {
            double weight = (scale * 6.0) * 9.0;
            if (weight < offset)
            {
                weight = weight + (double)71;
            }
            else
            {
                weight = weight - (weight * 5.0);
            }
            return weight + (weight / 8.0);
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading & 31) == (matches - reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
